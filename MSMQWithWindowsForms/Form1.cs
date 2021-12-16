using System;
using System.Data;
using System.Windows.Forms;

namespace MSMQWithWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
       

        private void sendMessage_Click(object sender, EventArgs e)
        {
            //Se crea un objeto de tipo Message llamado elMensaje
            System.Messaging.Message theMessage = new System.Messaging.Message(txtMessage.Text);
            theMessage.Label = txtName.Text;
            //Esta condicion valida las prioridades de los mensajes. Primero muestra los mensajes con mas alta prioridad en la cola de mensajes.
            if (highPriority.Checked)
                theMessage.Priority = System.Messaging.MessagePriority.Highest;
            else
                theMessage.Priority = System.Messaging.MessagePriority.Normal;
            helpRequestQueue.Send(theMessage);
            DisplayMessages();
        }

        //Se crea un metodo llamado DisplayMessages para poder mostrar el contenido de la cola en el DataGridView.
        private void DisplayMessages()
        {
            //Las propiedades de la cola se agregan a un objeto DataTable.
            DataTable messageTable = new DataTable();
            messageTable.Columns.Add("Name");
            messageTable.Columns.Add("Message");
            messageTable.Columns.Add("Priority");
            System.Messaging.Message[] messages;
            //Se usa el metodo MessageQueue.GetAllMessages para recuperar todos los mensajes de la cola
            messages = helpRequestQueue.GetAllMessages();
            //Se crea un formateador para el mensaje, con el fin de recuperar el texto del mensaje.
            System.Messaging.XmlMessageFormatter stringFormatter;
            stringFormatter = new System.Messaging.XmlMessageFormatter(
               new string[] { "System.String" });
            for (int index = 0; index < messages.Length; index++)
            {
                messages[index].Formatter = stringFormatter;
                messageTable.Rows.Add(new string[] {
                    messages[index].Label,
                    messages[index].Body.ToString(),
                    messages[index].Priority.ToString() });
            }
            messageGrid.DataSource = messageTable;
        }
        //Se llama al metodo de DisplayMessages para poder mostrar el contenido de la cola.
        private void refreshMessages_Click(object sender, EventArgs e)
        {
            DisplayMessages();
        }
        //Se llama al metodo Purge para poder borrar todos los mensajes de la cola de helpResquestQueue para que asimismo actualice el contenido del DataGridView que los muestra como un DataTable
        private void purgeMessages_Click(object sender, EventArgs e)
        {
            helpRequestQueue.Purge();
            DisplayMessages();
        }
    }
}
