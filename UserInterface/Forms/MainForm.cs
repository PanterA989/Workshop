using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using Workshop.DataAccessLayer.ViewModel;

namespace Workshop.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        private static IList<TaskViewModel> fakeTasks;


        //Singleton
        private static MainForm _instance = null;
        public static MainForm Instance { 
            get {
                if (_instance == null)
                {
                    _instance = new MainForm();
                    return _instance;
                }
                else return _instance;
            }
            private set { }
        }

        private MainForm()
        {
            InitializeComponent();

            fakeTasks = GetFakeTasks();
            PrepareTasksData();
        }

        private void PrepareTasksData()
        {
            bsTasks.DataSource = new BindingList<TaskViewModel>(fakeTasks);
            dgvTasks.DataSource = bsTasks;
        }

        private IList<TaskViewModel> GetFakeTasks()
        {
            IList<TaskModel> fakeTasksModel = new List<TaskModel>()
            {
                new TaskModel()
                {
                        Id = 1,
                        Status = new StatusModel("Przyjęty"),

                        FirstName = "Tomasz",
                        LastName = "Kasacki",
                        PhoneNumber ="664 123 767",
                        Email = "tomasz12@gmail.com",

                        BikeManufacturer = "Kross",
                        BikeModel = "Vento 2 (czarno-limonkowy) 2020 aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                        FrameNumber = "LX9370137430",
                        AdditionalInfo ="Serwisowany regularnie u nas",

                        StartDate = DateTime.Today,
                        EndDate = DateTime.Today.AddDays(7),
                        Cost = 120.00m ,
                        TaskDescription ="Przegląd sezonowy"
                },

                new TaskModel()
                {
                        Id = 2,
                        Status = new StatusModel("Do odbioru"),

                        FirstName = "Katarzyna",
                        LastName = "Olbryska",
                        PhoneNumber ="343 222 787",
                        Email = "katarzyna@gmail.com",

                        BikeManufacturer = "Rock Machine",
                        BikeModel = "Manhattan 90-29",
                        FrameNumber = "LX3242512798",
                        AdditionalInfo ="Pierwszy raz u nas",

                        StartDate = DateTime.Today.AddDays(-3),
                        EndDate = DateTime.Today.AddDays(4),
                        Cost = 50.15m,
                        TaskDescription ="Wymiana korby"
                },

                new TaskModel()
                {
                        Id = 3,
                        Status = new StatusModel("Zrealizowany"),

                        FirstName = "Igor",
                        LastName = "Wąski",
                        PhoneNumber ="423 323 645",
                        Email = "igor123@gmail.com",

                        BikeManufacturer = "Trek",
                        BikeModel = "Excalibur",
                        FrameNumber = null,
                        AdditionalInfo ="Stały klient, nowy rower",

                        StartDate = DateTime.Today.AddDays(-7),
                        EndDate = DateTime.Today,
                        Cost = 150.00m,
                        TaskDescription ="Montaż roweru"
                },

                new TaskModel()
                {
                        Id = 4,
                        Status = new StatusModel("Anulowany - do odbioru"),

                        FirstName = null,
                        LastName = null,
                        PhoneNumber ="556 566 978",
                        Email = null,

                        BikeManufacturer = "Scott",
                        BikeModel = "Scale RC 900",
                        FrameNumber = null,
                        AdditionalInfo = null,

                        StartDate = DateTime.Today.AddDays(-9),
                        EndDate = null,
                        Cost = null,
                        TaskDescription ="Sprawdzić"
                },

                new TaskModel()
                {
                        Id = 4,
                        Status = new StatusModel("Anulowany - odebrany"),

                        FirstName = null,
                        LastName = null,
                        PhoneNumber ="767 666 234",
                        Email = null,

                        BikeManufacturer = "Scott",
                        BikeModel = "Genius 920",
                        FrameNumber = null,
                        AdditionalInfo = null,

                        StartDate = DateTime.Today.AddDays(-12),
                        EndDate = null,
                        Cost = null,
                        TaskDescription ="Test"
                }
            };

            IList<TaskViewModel> fakeTasksViewModel = new List<TaskViewModel>();

            foreach (TaskModel fakeTaskModel in fakeTasksModel)
            {
                TaskViewModel fakeTaskViewModel = new TaskViewModel();
                fakeTaskViewModel.Id = fakeTaskModel.Id;
                fakeTaskViewModel.BikeManufacturer = fakeTaskModel.BikeManufacturer;
                fakeTaskViewModel.BikeModel = fakeTaskModel.BikeModel;
                fakeTaskViewModel.StartDate = fakeTaskModel.StartDate;
                fakeTaskViewModel.EndDate = fakeTaskModel.EndDate;
                fakeTaskViewModel.Status = fakeTaskModel.Status.ToString();

                fakeTasksViewModel.Add(fakeTaskViewModel);
            }

            return fakeTasksViewModel;

        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja nie jest jeszcze wspierana.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
