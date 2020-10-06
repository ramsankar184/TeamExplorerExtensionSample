using System;
using Microsoft.TeamFoundation.Controls;

namespace TeamExplorerViewChangeset
{
    [TeamExplorerNavigationItem(ViewChangeset.SectionId, 1)]
    public class ViewChangeset : ITeamExplorerNavigationItem
    {
        public const string SectionId = "01058231-C6F3-4937-BFEB-14D0C63E271F";

        public string Text => "View Changeset";

        public System.Drawing.Image Image => System.Drawing.Image.FromFile("ViewChangeset.png");
        
        public bool IsVisible => true;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Execute()
        {
            System.Windows.Forms.MessageBox.Show("Test Success");
        }

        public void Invalidate()
        {

        }
    }
}
