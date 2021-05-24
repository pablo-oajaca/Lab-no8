using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_no8
{
    public partial class _Default : Page
    {
        List<Departamento> departamentos = new List<Departamento>();
        List<Temperatura> temperaturas = new List<Temperatura>();

            

        private void Leer()
        {
            string FileName = Server.MapPath("Departamento.txt");

            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Departamento departamento = new Departamento();
                departamento.Id = Convert.ToInt32(reader.ReadLine());
                departamento.Nombre = reader.ReadLine();

                departamentos.Add(departamento);


            }

            reader.Close();

            DropDownListDepartamento.DataValueField = "Id";
            DropDownListDepartamento.DataTextField = "Nombre";

            DropDownListDepartamento.DataSource = departamentos;
            DropDownListDepartamento.DataBind();


        }
         private void Guardar()
        {
            string FileName = Server.MapPath("temperaturas.txt");

            FileStream stream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach(var temperatura in temperaturas)
            {
                writer.WriteLine(temperatura.Departamento);
                writer.WriteLine(temperatura.TemperaturaLeida);
            }

            writer.Close();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Leer();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Temperatura temperatura = new Temperatura();

            temperatura.Departamento = Convert.ToInt32(DropDownListDepartamento.SelectedValue);
            temperatura.TemperaturaLeida = Convert.ToInt32(TextBox1.Text);

            temperaturas.Add(temperatura);
            Guardar();


        }
    }
}