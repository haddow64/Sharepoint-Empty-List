using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using Form = System.Windows.Forms.Form;

namespace SharepointEmptyList
{
    public partial class SharepointForm : Form
    {
        public SharepointForm( )
        {
            InitializeComponent();

            labelSharepointItemsCount.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private static int SharepointItemCount(string url, string list)
        {
            try
            {
                var clientContext = new ClientContext(url);
                List oList = clientContext.Web.Lists.GetByTitle(list);
                clientContext.Load(oList);
                clientContext.ExecuteQuery();
                var count = oList.ItemCount;

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show((ex.ToString()));
                return -1;
            }
        }

        private string SharepointItemDelete(string url, string list)
        {
            try
            {
                var clientContext = new ClientContext(url);
                List oList = clientContext.Web.Lists.GetByTitle(list);

                var daysToDelete = numericUpDownDaysToDelete.Value*-1;

                var camlQuery = new CamlQuery
                {
                    ViewXml = "<View><Query><Where><Neq><FieldRef Name='Created' /><Value Type='DateTime'><Today Offset=" +
                        daysToDelete + " /></Value></Neq></Where></Query></View>"
                };

                ListItemCollection listItems = oList.GetItems(camlQuery);

                clientContext.Load(listItems,
                    eachItem => eachItem.Include(
                        item => item,
                        item => item["ID"]));
                clientContext.ExecuteQuery();

                int totalListItems = listItems.Count;

                toolStripStatusLabel.Text = string.Format("Deletion in {0}list:", list);

                while (totalListItems > 0)
                {
                     // 100 is the max display limit for a single page of list items
                    for (var counter = 100 - 1; counter > -1; counter--)
                    {
                        listItems[counter].DeleteObject();
                        toolStripStatusLabel.Text = string.Format("Row: {0} Item Deleted", counter);
                    }
                    clientContext.ExecuteQuery();
                    totalListItems--;
                }

                return "success";
            }
            catch (ArgumentOutOfRangeException)
            {
                // Do not throw - this will be the result if the list has < 100 "new" items mixed with "old" items
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show((ex.ToString()));
                return "error";
            }
        }

        private void buttonGetCount_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            labelSharepointItemsCount.Visible = true;
            int count = SharepointItemCount(textBoxURL.Text, textBoxListName.Text);
            labelSharepointItemsCount.Text = count.ToString(CultureInfo.InvariantCulture);

            Cursor.Current = Cursors.Default;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            toolStripStatusLabel.Visible = true;
            string success = SharepointItemDelete(textBoxURL.Text, textBoxListName.Text);
            toolStripStatusLabel.Text = success;

            Cursor.Current = Cursors.Default;
        }

        private void buttonURLLocalhost_Click(object sender, EventArgs e)
        {
            textBoxURL.Text = @"http://127.0.0.1";
        }
    }
}