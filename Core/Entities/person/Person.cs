using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.person;

public class Person
{
    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime RegistreDate { get; set; }
    public int IdDocumTypeFk { get; set; }
    public int IdRolePersFk { get; set; }
    public int IdTypePersFk { get; set; }
    public DocumentType DocumentTypes { get; set; }
    public RolePerson RolePersons { get; set; }
    public TypePerson TypePersons { get; set; }
}
