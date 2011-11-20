using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebFormsMvp;
using Swtor.Presentation.ViewModel.Views.Models;
using Swtor.Business;
using Swtor.Common;

namespace Swtor.Presentation.ViewModel.Presenters
{
    public class DefaultPresenter : Presenter<IView<DefaultModel>>
    {
        public DefaultPresenter(IView<DefaultModel> view)
            : base(view)
        {
            View.Load += Load;
        }

        void Load(object sender, EventArgs e)
        {
            TextComponent textc = new TextComponent(Constants.TestTextName);
            View.Model.TestText = textc.Text;
        }
    }
}
