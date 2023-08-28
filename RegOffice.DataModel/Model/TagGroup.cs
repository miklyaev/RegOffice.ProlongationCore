using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class TagGroup
    {
        public TagGroup()
        {
            Tags = new HashSet<Tag>();
        }


        /// <summary>
        /// Ид. группа
        /// </summary>
        public int TagGroupId { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string TagGroupName { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
