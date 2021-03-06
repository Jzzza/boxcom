//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Linq;

namespace boxcom.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boxer
    {
        public int IdBoxer { get; set; }
        public string NAME { get; set; }
        public string LINK_PHOTO { get; set; }
        public Nullable<int> W { get; set; }
        public Nullable<int> L { get; set; }
        public Nullable<int> D { get; set; }
        public Nullable<int> KO { get; set; }
        public Nullable<int> LOSS_KO { get; set; }
        public string RANKING { get; set; }
        public Nullable<int> ROUNDS { get; set; }
        public Nullable<System.DateTime> DEBUT { get; set; }
        public Nullable<int> HEIGHT { get; set; }
        public Nullable<int> REACH { get; set; }
        public Nullable<int> BOUTS { get; set; }
        public Nullable<System.DateTime> BORN { get; set; }

        public List<Boxer> getBoxers()
        {
            var context = new FromBoxRecEntities2();
            return context.Boxer.ToList();
        }
        public Boxer getBoxer(string name)
        {
            return getBoxers().Where(x => x.NAME.Contains(name)).FirstOrDefault();
        }
    }
}
