using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ternary.Engine.OnBase.Models;

namespace Ternary.Engine.OnBase.Types;

public class PhysicalPlatter : OnBaseType<Physicalplatter>
{
    public DiskGroup? DiskGroup { get; set; }
    public string? LstUsedDrive { get; set; }
    public long SpaceUsed { get; set; }
}
public class DiskGroup : OnBaseType<Diskgroup>
{
    public long DiskGroupType { get; set; }
    public long FileCount { get; set; }
    public PhysicalPlatter? PhysicalPlatters { get; set; }
}
public class UserGroup : OnBaseType<Usergroup>
{
    public List<DocumentType> DocumentTypes { get; set; } = [];
}
public class FileType : OnBaseType<Filetype>
{
    public string? Extension { get; set; }
    public string? CommandLine { get; set; }
    public string? MimeType { get; set; }
}
public class KeywordType : OnBaseType<Keytypetable>
{
    public long DataType { get; set; }
    public long MaxLength { get; set; }
    public string? Mask { get; set; }
    public List<DocumentType> DocumentTypes { get; set; } = [];
}
public class DocumentTypeGroup : OnBaseType<Itemtypegroup>
{
    public List<DocumentType> DocumentTypes { get; set; } = [];
}
public class DocumentType : OnBaseType<Doctype>
{
    public DocumentTypeGroup? DocumentTypeGroup { get; set; }
    public List<KeywordType> KeywordTypes { get; set; } = [];
    public List<UserGroup> UserGroups { get; set; } = [];
    public DiskGroup? DefaultDiskGroup { get; set; }
    public FileType? DefaultFileType { get; set; }
}


public abstract class OnBaseType<T> : OnBaseType
{
    public new T? Entity { get; set; }
}
public abstract class OnBaseType : IOnBaseType
{
    public virtual object? Entity { get; set; }
    public virtual long Id { get; set; }
    public virtual string? Name { get; set; }
}

public interface IOnBaseType
{
    object? Entity { get; set; }
    long Id { get; set; }
    string? Name { get; set; }
}