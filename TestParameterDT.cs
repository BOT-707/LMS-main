//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestParameterDT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestParameterDT()
        {
            this.ReferenceValuesDTs = new HashSet<ReferenceValuesDT>();
        }
    
        public long Test_P_ID { get; set; }
        public Nullable<int> GrpID { get; set; }
        public long TestID { get; set; }
        public string GroupName { get; set; }
        public string TestName { get; set; }
        public string TestParam { get; set; }
        public string TSubParam { get; set; }
        public string InputType { get; set; }
        public string PGroupBy { get; set; }
        public string DefaultResult { get; set; }
        public string PreResult { get; set; }
        public string Lower_Ref { get; set; }
        public string Higher_Ref { get; set; }
        public string Units { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Min_Age { get; set; }
        public string MinAge_unit { get; set; }
        public Nullable<int> Max_Age { get; set; }
        public string Max_Age_unit { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Inorder { get; set; }
        public Nullable<int> SbInorder { get; set; }
        public string ShSTS { get; set; }
    
        public virtual GroupDT GroupDT { get; set; }
        public virtual TestDT TestDT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReferenceValuesDT> ReferenceValuesDTs { get; set; }
    }
}
