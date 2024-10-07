using Maui_DatabindingDemo.Models;

namespace Maui_DatabindingDemo
{
    Person person = new Person();
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            person = new Person
            {
                Name = "John",
                Phone = "1234567",
                Address = "X Address"
            };

            BindingContext = person;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            person.Name = "Peter";
            person.Phone = "00000";
            person.Address = "New Address";

            //person = new Person
            //{
            //    Name = "Peter",
            //    Phone = "00000",
            //    Address = "New Address"
            //};

            //txtName.BindingContext = person;
            //txtName.SetBinding(Label.TextProperty, "Name");

            //Binding personBinding = new Binding();

            //personBinding.Source = person;
            //personBinding.Path = "Name";

            //txtName.SetBinding(Label.TextProperty, personBinding);
            // Remember, I need to create a binding specifying the source of information and finally establish the
            // source to the will property which will take the data from the information source, which in this case
            // is a property called name.
        }
    }

}
