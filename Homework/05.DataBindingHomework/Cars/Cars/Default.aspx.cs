using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cars
{
    public partial class _Default : Page
    {
        CarsDbContext context = new CarsDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateModels();
        }

        public IQueryable GetProducers(object sender, EventArgs e)
        {
            return context.Producers;
        }

        public IQueryable GetEngines(object sender, EventArgs e)
        {
            return context.Engines;
        }

        public IQueryable GetExtras(object sender, EventArgs e)
        {
            return context.Extras;
        }

        public void Submit(object sender, EventArgs e)
        {
            this.Result.Text = $"Producer={this.ProducerInput.Text}; Model={this.ModelInput.Text}; Engine type={this.EngineRadioButtons.SelectedValue}; Extras=[{string.Join(", ", GetSelectedExtras())}]";
        }

        private List<string> GetSelectedExtras()
        {
            var selectedItems = this.ExtrasCheckBoxList.Items.Cast<ListItem>()
                .Where(i => i.Selected)
                .Select(i => i.Text)
                .ToList();

            return selectedItems;
        }

        protected void ProducerInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateModels();
        }

        private void UpdateModels()
        {
            var modelsByProducer = context.Models.Where(m => m.Producer.Name == this.ProducerInput.SelectedValue).ToList();
            this.ModelInput.DataSource = modelsByProducer;
            this.ModelInput.DataBind();
        }
    }
}