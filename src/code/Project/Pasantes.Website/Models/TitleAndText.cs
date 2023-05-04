using Pasantes.Website.Models.GlassMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
﻿using Glass.Mapper.Sc.Fields;

namespace Pasantes.Website.Models
{
    public class TitleAndText : BaseItem
    {
        public virtual string Title { get; set; }

        public virtual string Text { get; set; }

    }
}