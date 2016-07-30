﻿using System.ComponentModel.Composition;
using GitClientVS.Contracts.Interfaces.Views;
using GitClientVS.Infrastructure;
using GitClientVS.UI;
using GitClientVS.VisualStudio.UI.TeamFoundation;
using Microsoft.TeamFoundation.Controls;

namespace GitClientVS.VisualStudio.UI.Pages
{
    [TeamExplorerPage(PageIds.PullRequestsMainPageId)]
    public class PullRequestsMainPage : TeamExplorerBasePage
    {

        [ImportingConstructor]
        public PullRequestsMainPage(IPullRequestsMainView view)
        {
            Title = Resources.PullRequestNavigationItemTitle;
            PageContent = view;
        }
    }
}