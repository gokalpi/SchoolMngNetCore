using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Entities.Admission
{
    public class Parent : Person
    {
        public ERelationType Relationship { get; set; }
        public EParentStatus Status { get; set; }

        public virtual ICollection<StudentParent> Children { get; set; }
    }

    public enum EParentStatus : byte
    {
        Passive = 0,
        Active
    }

    public enum ERelationType : byte
    {
        Mother = 1,
        Father,
        GrandMother,
        GrandFather,
        Guardian
    }
}