using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Project
{
    class Presenter
    {
        private Model model;
        private MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.AddChoice += MainWindow_AddChoice;
            this.mainWindow.SubChoice += MainWindow_SubChoice;
            this.mainWindow.MultChoice += MainWindow_MultChoice;
            this.mainWindow.DivChoice += MainWindow_DivChoice;
        }

        private void MainWindow_DivChoice(object sender, EventArgs e)
        {
            this.mainWindow.ResultTextBox.Text = model.Div(mainWindow.Data()[0],
                mainWindow.Data()[1]).ToString();
        }

        private void MainWindow_MultChoice(object sender, EventArgs e)
        {
            this.mainWindow.ResultTextBox.Text = model.Mult(mainWindow.Data()[0],
                mainWindow.Data()[1]).ToString();
        }

        private void MainWindow_SubChoice(object sender, EventArgs e)
        {
            this.mainWindow.ResultTextBox.Text = model.Sub(mainWindow.Data()[0],
                mainWindow.Data()[1]).ToString();
        }

        private void MainWindow_AddChoice(object sender, EventArgs e)
        {
            this.mainWindow.ResultTextBox.Text = model.Add( mainWindow.Data()[0],
                mainWindow.Data()[1]).ToString();
        }
    }
}       
