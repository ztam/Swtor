using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swtor.Business.Entities;
using Swtor.Common;

namespace Swtor.Data
{
    public class TextDAL
    {
        public static Text Load(string textName)
        {
            using (SwtorContext context = new SwtorContext())
            {
                var q = from text in context.Texts where text.Name == Constants.TestTextName select text;
                return q.FirstOrDefault();
            }
        }

        public static Text Save(int textId, string content)
        {
            using (SwtorContext context = new SwtorContext())
            {
                var text = context.Texts.Where(p => p.TextId == textId).FirstOrDefault();
                context.Entry(text).State = System.Data.EntityState.Modified;
                text.Content = content;
                context.SaveChanges();
                return text;
            }
        }
    }
}
