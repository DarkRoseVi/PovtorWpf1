//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PovtorWpf1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ReqiesrUser = new HashSet<ReqiesrUser>();
        }
    
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> StatusUserId { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReqiesrUser> ReqiesrUser { get; set; }
        public virtual Role Role { get; set; }
        public virtual StatusUser StatusUser { get; set; }
    }
}
