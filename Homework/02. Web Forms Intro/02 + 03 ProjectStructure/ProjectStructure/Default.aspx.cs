using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectStructure
{
    public partial class _Default : Page
    {
        static List<string> checkpoints = new List<string>();

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["checkpoints"] != null) return;
            Session.Add("checkpoints", new List<string>());
            (Session["checkpoints"] as List<string>).Add("PreInit - PreInit is the first event in page life cycle. It checks the IsPostBack property and determines whether the page is a postback. It sets the themes and master pages, creates dynamic controls, and gets and sets profile property values. This event can be handled by overloading the OnPreInit method or creating a Page_PreInit handler.");
        }

        protected void Page_Init()
        {
            (Session["checkpoints"] as List<string>).Add("Init - Init event initializes the control property and the control tree is built. This event can be handled by overloading the OnInit method or creating a Page_Init handler.");
        }

        protected void Page_InitComplete()
        {
            (Session["checkpoints"] as List<string>).Add("InitComplete - InitComplete event allows tracking of view state. All the controls turn on view-state tracking.");
        }

        protected void Page_LoadViewState()
        {
            (Session["checkpoints"] as List<string>).Add("LoadViewState - LoadViewState event allows loading view state information into the controls.");
        }

        protected void Page_LoadPostData()
        {
            (Session["checkpoints"] as List<string>).Add("LoadPostData - During this phase, the contents of all the input fields are defined with the <form> tag are processed.");
        }

        protected void Page_PreLoad()
        {
            (Session["checkpoints"] as List<string>).Add("PreLoad - PreLoad occurs before the post back data is loaded in the controls. This event can be handled by overloading the OnPreLoad method or creating a Page_PreLoad handler.");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.FromCSharpCode.InnerHtml = "Hello, ASP.NET from C#";
            this.Location.InnerHtml = "Location: " + Assembly.GetExecutingAssembly().Location.ToString();
            (Session["checkpoints"] as List<string>).Add("Load - The Load event is raised for the page first and then recursively for all child controls. The controls in the control tree are created. This event can be handled by overloading the OnLoad method or creating a Page_Load handler.");
        }

        protected void Page_LoadComplete()
        {
            (Session["checkpoints"] as List<string>).Add("LoadComplete - The loading process is completed, control event handlers are run, and page validation takes place. This event can be handled by overloading the OnLoadComplete method or creating a Page_LoadComplete handler");
        }

        protected void Page_PreRender()
        {
            (Session["checkpoints"] as List<string>).Add("PreRender - The PreRender event occurs just before the output is rendered. By handling this event, pages and controls can perform any updates before the output is rendered.");
        }

        protected void Page_PreRenderComplete()
        {
            (Session["checkpoints"] as List<string>).Add("PreRenderComplete - As the PreRender event is recursively fired for all child controls, this event ensures the completion of the pre-rendering phase.");
        }

        protected void Page_SaveStateComplete()
        {
            (Session["checkpoints"] as List<string>).Add("SaveStateComplete - State of control on the page is saved. Personalization, control state and view state information is saved. The HTML markup is generated. This stage can be handled by overriding the Render method or creating a Page_Render handler.");
            this.CheckpointsContainer.InnerHtml = FormatMessage(Session["checkpoints"] as List<string>);
        }

        protected void Page_UnLoad()
        {
            (Session["checkpoints"] as List<string>).Add("UnLoad - The UnLoad phase is the last phase of the page life cycle. It raises the UnLoad event for all controls recursively and lastly for the page itself. Final cleanup is done and all resources and references, such as database connections, are freed. This event can be handled by modifying the OnUnLoad method or creating a Page_UnLoad handler.");
        }

        private string FormatMessage(List<string> message)
        {
            var result = new StringBuilder();
            result.Append("<ul>");
            foreach (var item in message)
            {
                result.Append("<li>");
                result.Append(item);
                result.Append("</li>");
            }
            result.Append("</ul>");

            return result.ToString();
        }
    }
}