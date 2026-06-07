using Ternary.Engine.OnBase.Models;
using Ternary.Engine.OnBase.Types;

namespace Ternary.Engine.OnBase.Services;

public class OnBaseService 
{
    private IDynamicContextFactory _contextFactory;
    private ILogger<OnBaseService> _logger;
    public OnBaseService(IDynamicContextFactory contextFactory, ILogger<OnBaseService> logger)
    {
        _contextFactory = contextFactory;
        _logger = logger;
    }
    public OnBaseDbContext GetDbContext() => _contextFactory.CreateContext<OnBaseDbContext>();

    public async Task<DocumentType?> GetDocumentType(long? id)
    {
        if (!id.HasValue)
            return null;
        DocumentType docType = null;
        using var db = GetDbContext();
        var dt = await db.FindAsync<Doctype>(id.Value);
        if(dt != null)
        {
            docType = new DocumentType
            {
                Entity = dt,
                Id = dt.Itemtypenum,
                Name = dt.Itemtypename,
                DocumentTypeGroup = await GetDocumentTypeGroup(dt.Itemtypegroupnum),
                KeywordTypes = await GetDocTypeKeyTypes(dt.Itemtypenum),
                UserGroups = await GetDocTypeUserGroups(dt.Itemtypenum),
                DefaultFileType = await GetFileType(dt.Filetypenum)
            };
        }
        return docType;
    }
    public async Task<DocumentTypeGroup?> GetDocumentTypeGroup(long? id)
    {
        if (!id.HasValue)
            return null;
        DocumentTypeGroup docTypeGrp = null;
        using var db = GetDbContext();
        var dtg = await db.FindAsync<Itemtypegroup>(id.Value);
        if (dtg != null)
        {
            docTypeGrp = new DocumentTypeGroup
            {
                Entity = dtg,
                Id = dtg.Itemtypegroupnum,
                Name = dtg.Itemtypegroupname,                
            };
        }
        return docTypeGrp;
    }
    public async Task<List<KeywordType>> GetDocTypeKeyTypes(long docTypeId)
    {
        List<KeywordType> keyTypes = [];
        using var db = GetDbContext();
        await Task.Run(() => db.Itemtypexkeywords
            .AsQueryable()
            .Where(k => k.Itemtypenum == docTypeId)
            .ToList()
            .ForEach(async x =>
            {
                var kt = await GetKeywordType(x.Keytypenum);
                if (kt != null)
                    keyTypes.Add(kt);
            }));
        return keyTypes;
    }
    public async Task<KeywordType> GetKeywordType(long? id)
    {
        if (!id.HasValue)
            return null;
        KeywordType? keyType = null;

        using var db = GetDbContext();
        var kt = await db.FindAsync<Keytypetable>(id.Value);
        if (kt != null)
        {
            keyType = new KeywordType
            {
                Entity = kt,
                Id = kt.Keytypenum,
                Name = kt.Keytype,
                DataType = kt.Datatype.GetValueOrDefault(),
                Mask = kt.Keytypemask,
                DocumentTypes = await GetKeyTypeDocTypes(kt.Keytypenum)
            };
        }
        return keyType;
    }
    public async Task<List<DocumentType>> GetKeyTypeDocTypes(long keyTypeId)
    {
        List<DocumentType> docTypes = [];
        using var db = GetDbContext();
        await Task.Run(() => db.Itemtypexkeywords
            .AsQueryable()
            .Where(k => k.Keytypenum == keyTypeId)
            .ToList()
            .ForEach(async x =>
            {
                var dt = await GetDocumentType(x.Keytypenum);
                if (dt != null)
                    docTypes.Add(dt);
            }));
        return docTypes;
    }

    public async Task<UserGroup?> GetUserGroup(long? id)
    {
        if (!id.HasValue)
            return null;
        UserGroup? item = null;

        using var db = GetDbContext();
        var e = await db.FindAsync<Usergroup>(id.Value);
        if (e != null)
        {
            item = new UserGroup
            {
                Entity = e,
                Id = e.Usergroupnum,
                Name = e.Usergroupname,
                DocumentTypes = await GetUserGroupDocTypes(e.Usergroupnum)
            };
        }
        return item;
    }
    public async Task<List<UserGroup>> GetDocTypeUserGroups(long docTypeId)
    {
        List<UserGroup> collection = [];
        using var db = GetDbContext();
        await Task.Run(() => db.Usergroupconfigs
            .AsQueryable()
            .Where(i => i.Itemtypenum == docTypeId)
            .ToList()
            .ForEach(async x =>
            {
                var item = await GetUserGroup(x.Usergroupnum);
                if (item != null)
                    collection.Add(item);
            }));
        return collection;
    }
    public async Task<List<DocumentType>> GetUserGroupDocTypes(long usergroupId)
    {
        List<DocumentType> collection = [];
        using var db = GetDbContext();
        await Task.Run(() => db.Usergroupconfigs
            .AsQueryable()
            .Where(i => i.Usergroupnum == usergroupId)
            .ToList()
            .ForEach(async x =>
            {
                var item = await GetDocumentType(x.Itemtypenum);
                if (item != null)
                    collection.Add(item);
            }));
        return collection;
    }
    public async Task<FileType?> GetFileType(long? id)
    {
        if (!id.HasValue)
            return null;
        FileType? item = null;

        using var db = GetDbContext();
        var e = await db.FindAsync<Filetype>(id.Value);
        if (e != null)
        {
            item = new FileType
            {
                Entity = e,
                Id = e.Filetypenum,
                Name = e.Filetypestr,
                Extension = e.Extension,
                CommandLine = e.Commandline,
                MimeType = e.Mimetype
            };
        }
        return item;
    }
    public async Task<DiskGroup?> GetDiskGroup(long? id)
    {
        if (!id.HasValue)
            return null;
        DiskGroup? item = null;

        using var db = GetDbContext();
        var e = await db.FindAsync<Diskgroup>(id.Value);
        if (e != null)
        {
            item = new DiskGroup
            {
                Entity = e,
                Id = e.Diskgroupnum,
                Name = e.Diskgroupname,
                FileCount = e.Filesindirectory.GetValueOrDefault(),
            };
        }
        return item;
    }
    public async Task<PhysicalPlatter?> GetPhysicalPlatter(long? id)
    {
        if (!id.HasValue)
            return null;
        PhysicalPlatter? item = null;

        using var db = GetDbContext();
        var e = await db.FindAsync<Physicalplatter>(id.Value);
        if (e != null)
        {
            item = new PhysicalPlatter
            {
                Entity = e,
                Id = e.Physicalplatternum,
                Name = string.Empty,
                DiskGroup = await GetDiskGroup(e.Diskgroupnum),
                SpaceUsed = e.Spaceused.GetValueOrDefault()
            };
        }
        return item;
    }
}
