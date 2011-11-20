using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsMvp.Web;
using Swtor.Presentation.ViewModel.Views.Models;
using WebFormsMvp;
using Swtor.Presentation.ViewModel.Presenters;

namespace Swtor.Presentation.Web
{
    [PresenterBinding(typeof(DefaultPresenter))]
    public partial class Default : MvpPage<DefaultModel>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}