using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swtor.Business.Entities;
using Swtor.Data;

namespace Swtor.Business
{
    public class TextComponent
    {
        public Text Text { get; set; }

        public TextComponent() { }

        public TextComponent(string textName)
        {
            Text = TextDAL.Load(textName);
        }

        public Text Save(int textId, string content)
        {
            return TextDAL.Save(textId, content);
        }
    }
}
