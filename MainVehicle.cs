using System.Runtime.Intrinsics.X86;

namespace CarInventory
{
    public partial class MainVehicle : Form
    {
        public MainVehicle()
        {
            InitializeComponent();//this is standard and will start my program
            LoadVehicleData();//this is going to be used throughout my program and its a method tht i will use and need to be public 
        }
        public class Vehicle
        {//this is my class which will be vehicles, i am using 5 common descriptions of the car that would be found in the database 
            //i am declaring this class and the properities inside of it so i can call to it later 
            public string Make { get; set; }// Make property, using a string because it will be words, and get will grab that data and set will store it to the make property
            public string Model { get; set; }//Model Property, String because of words, get will grab the string and convert it while set will store it in this property 
            public int Year { get; set; } //public because i want it to be accessed everywhere within this or associated files. integer because this will be a 4 digit number 
            public string Color { get; set; }//string again because the color will be words, public so it can have access, and get and set will grab and store the data 
            public double Price { get; set; } //using double here because it can hold decimals this will be good for the 9.99 ect 

            
        }
       
        private List<Vehicle> vehicles = new List<Vehicle>
        {//this is a basic list that i am starting with, I dont need this but it will place in a "main inventory" the others will be added during demo
            new Vehicle { Make = "Buick", Model = "Enclave", Year = 2019, Color = "Blue", Price = 20800.9 }, 
            //using the information from the class system i created a list first and then implemented new instances or objects within that. 
            new Vehicle { Make = "Ford", Model ="Raptor", Year = 2024, Color = "Green", Price = 78000.99}, 
            //when adding a digit you can just use a = then the number but when you use the a string or phrase you have to encapsulate them in ""
            new Vehicle { Make = "Toyota", Model = "Tacoma", Year= 1995, Color = "White", Price = 30000.5}, 
            //comma is normal instead of ; at the end of the line
            new Vehicle { Make = "Nissan", Model = "Altima", Year = 2020, Color = "Black", Price = 25000}, 
            //picked 5 generaic cars that i have implementd in this list 
            new Vehicle { Make = "Honda", Model = "Civic", Year = 2022, Color= "Red", Price= 16000.9}, 
        };//must add this ; at the end of this structure
        
        private void LoadVehicleData()
        {//this function update the vehicle data 
            dgvCarInventory.DataSource = null;//this clears all previous data to nothing 
            dgvCarInventory.DataSource = vehicles; //then reloads with all the current data 
            //im going to use this function when i add and remove a vehicle list 

        }
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {//this occurs when the add vehicle is added to the list 
            string Model = txtbxModel.Text;//retrieves data from the textbox model and if its a string it will be stored in Model Property
            string Make = txtbxVehicle.Text;//retrieves data from the vehicle make and then stores it where as a make property of this class 
            int Year = int.Parse(txtbxYear.Text);//gets the int or number data from vehicle year and places it under year property of the class vehicle 
            string Color = txtbxColor.Text;//retrieves data from vehicle color if string it then will be strored under vehicle color
            double Price = double.Parse(txtbxPrice.Text);// gets double number int tht can hold decimals that will first get and then store them under this property in the vehicle class 

            Vehicle newVehicle = new Vehicle
            {//vehicle class that will create a new object 
              Model = Model,//creates a new model, dynamically, 
              Make = Make,//sets a new make to this new vehicle 
              Year = Year, //creates a new vehicle with a new year 
              Color = Color, //dynamially sets a color for the new vehicle 
              Price = Price, //creates a new vehicle with a price from the above input text box 
            };
            //adds the new vehicle 
            vehicles.Add(newVehicle);
            //vehicles referes to the class, Add is a function to add it, and new Vehicle is comprised of all new information from the textbox 

            LoadVehicleData();
            //this is the function i made tht will clear the old student data and reload with the new informtion 
            
            //because i am done with the boxes i want to clear them out 
            txtbxVehicle.Clear();//clear the make of the vehicle text box
            txtbxModel.Clear();//clears out the model text box to nothing 
            txtbxYear.Clear(); //empties the text box year box 
            txtbxColor.Clear();// clears out the text box color input box 
            txtbxPrice.Clear(); //clears price input box 
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {//this event is what happens when the button is clicked 
            if (dgvCarInventory.SelectedRows.Count > 0)
            {//chekcs to first see if user has selected any rows and if it isnt nothing is run from this loop 
                Vehicle selectedVehicle = (Vehicle)dgvCarInventory.SelectedRows[0].DataBoundItem;
                //first goes to the selected row and then with databounditem grabs every information from that row to become encapsulated and referred to when being removed
                vehicles.Remove(selectedVehicle);
                //this will actually remove the data that has previously been selected. Remove is a method that is embedded in C# 
                LoadVehicleData(); 
                //this will now show the updated vehicle data without the deleted items. 
            }
            else
            {//This is what occurs when you dont select a row or it shows as zero which means nothing has been selected 
                MessageBox.Show("Please select a Vehicle to Remove before Continuing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                //this message pop up box will show up and dispay a pop up message with error as title and the message that i put in quotes along with ok button 
            }
        }
        private void txtbxVehicle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
