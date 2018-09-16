using ControlBusiness.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlBusiness.BusinessHelpers
{
    public class General
    {
        static GeneralB genB = new GeneralB();

        public static void DoError(Exception ex, string caption, MessageBoxButtons buttons,
                MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DoErrorExtra(ex, "", caption, buttons, icon, defaultButton);
        }

        public static void DoErrorExtra(Exception ex, string extra, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            var message = "";
            try
            {
                if (ex.InnerException != null)
                {
                    if (!string.IsNullOrEmpty(ex.InnerException.Message))
                        message += ex.InnerException.Message;

                    if ((ex.InnerException).InnerException != null)
                    {
                        if (!string.IsNullOrEmpty((ex.InnerException).InnerException.Message))
                            message += (ex.InnerException).InnerException.Message;
                    }
                }
                message += " " + ex.Message + " " + ex.StackTrace + " " + extra;
                Clipboard.SetText(message);
                MessageBox.Show(message, caption, buttons, icon,
                    defaultButton);

                genB.SaveBitacora(message, true, BaseHelpers.Helpers.Tools.UserCredentials.UserId);

                //EventLogEntryType entry = EventLogEntryType.Error;
                //switch (icon)
                //{
                //    case MessageBoxIcon.Asterisk:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    case MessageBoxIcon.Error:
                //        entry = EventLogEntryType.Error;
                //        break;
                //    case MessageBoxIcon.Exclamation:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    case MessageBoxIcon.None:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    case MessageBoxIcon.Question:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    default:
                //        entry = EventLogEntryType.Information;
                //        break;
                //}
                //if (!EventLog.SourceExists("ControlApp"))
                //    EventLog.CreateEventSource("ControlApp", "Application");

                //EventLog.WriteEntry("ControlApp", message, entry);                    
            }
            catch (Exception exc)
            {
                Clipboard.SetText(exc.Message);
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

        }

        /// <summary>
        /// abstract class
        /// </summary>
        public abstract class User // es abstracto por lo tanto no se puede hacer new, 
            //no tiene sentido
        {
            public string UserName { get; set; }

            public User(string name = "NoName")
            {
                UserName = name;
            }

            // A single virtual method.
            public virtual void SayName()
            {
                MessageBox.Show(UserName + " Inside User.SayName()");
            }
        }
        // Manager DOES NOT override Draw().
        public class Manager : User
        {
            public Manager()
            {
            }
            public Manager(string name)
                : base(name)
            {
            }
        }
        // Operator DOES override Draw().
        public class Operator : User, IAccess // interfaced
        {
            public Operator()
            {
            }
            public Operator(string name)
                : base(name)
            {

            }
            public override void SayName()
            {
                MessageBox.Show("Name {0} the Operator", UserName);
            }
            public class SuperUser : User
            {
                // Hide any SayName() implementation above me.
                public new void SayName()
                {
                    MessageBox.Show("Name {0} the SuperUser totally new", UserName);
                }
            }

            byte IAccess.GetDatabaseRole()
            {
                return 1;
            }

            bool IAccess.AccessGranted
            {
                get { return true; }
            }
        }
        // This interface defines the behavior of "having access."
        public interface IAccess
        {
            // Implicitly public and abstract.
            byte GetDatabaseRole();
            bool AccessGranted { get; }
        }

    }
}