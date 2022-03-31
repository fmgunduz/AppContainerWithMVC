namespace ContainerAppMvc.Models
{
    public class AppModel
    {
        

        public AppModel(string name, string description, string primaryColor, string secondaryColor, string imageName,string appUrl)
        {
            this.Name = name;
            this.Description = description; 
            this.PrimaryColor = primaryColor;
            this.SecondaryColor = secondaryColor;
            this.ImageName = imageName;
            this.AppUrl = appUrl;
               
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string ImageName { get; set; }
        public string AppUrl { get; set; }
    }
}
