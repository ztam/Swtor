using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Swtor.Business;
using Swtor.Business.Entities;

namespace Swtor.Presentation.Web
{
    /// <summary>
    /// Summary description for InternalService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class InternalService : System.Web.Services.WebService
    {

        [WebMethod]
        public string TextSave(int textId, string content)
        {
            TextComponent tcom = new TextComponent();
            tcom.Save(textId, content);
            return tcom.Text.Content;

        }
    }
}
