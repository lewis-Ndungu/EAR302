using System;
using System.IO;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormStudentDetails : Form
    {
        string file;
        bool create, read, write, delete = false;
        public FormStudentDetails()
        {
            InitializeComponent();
            rtb_read_file.Visible = false;

        }

        private void btn_folder_select_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Create a Folder." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fbd.SelectedPath);
                    box_path_created.Text = fbd.SelectedPath;
                }
            }
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            file = Path.Combine(box_path_created.Text + @"\" + box_first_name.Text + " " + box_last_name.Text + cb_file_extension.Text);
            string message = "Success " + box_first_name + " " + box_last_name.Text + cb_file_extension.Text;

            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("Contents of  \"" + box_first_name.Text + " " + box_last_name.Text + cb_file_extension.Text + "\"  are :\n");
            sw.WriteLine(label1.Text + " \t   " + box_first_name.Text);
            sw.WriteLine(label2.Text + " \t   " + box_last_name.Text);
            sw.WriteLine(label3.Text + "  " + box_registrationNo.Text);
            sw.WriteLine(label4.Text + " \t\t   " + cb_gender.Text);
            sw.WriteLine(label5.Text + " \t\t   " + box_course.Text);
            sw.WriteLine(label8.Text + " " + rtb_student_content.Text);
            sw.Close();

            MessageBox.Show(message, "Data Entry Error");
        }
        private void btn_read_file_Click(object sender, EventArgs e)
        {
            rtb_read_file.Visible = true;
            string fileName = Path.Combine(box_path_created.Text + @"\" + box_first_name.Text + " " + box_last_name.Text + cb_file_extension.Text);

            StreamReader sr = new StreamReader(fileName);
            rtb_read_file.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            box_first_name.Clear();
            box_last_name.Clear();
            box_registrationNo.Clear();
            cb_gender.DropDownStyle = ComboBoxStyle.Simple;
            cb_gender.Text = "Female";
            cb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            box_course.Clear();
            rtb_student_content.Clear();
        }

        private void cb_folder_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_folder_choice != null)
            {
                if(cb_folder_choice.Text == "Create a New Folder")
                {
                    label_editable.Visible = true;
                    box_path_created.Visible = true;
                    btn_folder_create.Visible = true;

                    label_editable2.Visible = false;
                    box_folder_existing.Visible = false;
                    btn_folder_exist.Visible = false;
                }
                else if(cb_folder_choice.Text == "Choose Existing Folder")
                {
                    label_editable2.Visible = true;
                    box_folder_existing.Visible = true;
                    btn_folder_exist.Visible = true;

                    label_editable.Visible = false;
                    box_path_created.Visible = false;
                    btn_folder_create.Visible = false;

                }
            }
        }

        private void btn_folder_exist_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your Path:" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fbd.SelectedPath);
                    box_path.Text = fbd.SelectedPath;
                }
            }
        }

        private void box_first_name_TextChanged(object sender, EventArgs e)
        {
            rtb_read_file.Visible = false ;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your Path:" })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    box_path.Text = fbd.SelectedPath;
                }
            }
        }

        private void btn_fileExplore_back_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        private void btn_fileExplorer_forward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }

        private void btn_fileExplore_back1_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }


        private void cb_file_handling_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cb_folder_choice != null)
            {
                if (cb_file_handling.Text == "Create a File")
                {
                    txt_file_action.Text = "Create a File:";
                    btn_fileHandling.Text = "Create";
                    rtb_file_action.Visible = false;
                    txt_content.Visible = false;
                    btn_save.Visible = false;
                    create = true;
                    read = false;
                    write = false;
                    delete = false;
                }

                else if (cb_file_handling.Text == "Read a File")
                {
                    txt_file_action.Text = "Read a File:";
                    btn_fileHandling.Text = "Read";
                    rtb_file_action.Visible = true;
                    txt_content.Visible = true;
                    btn_save.Visible = false;
                    create = false;
                    read = true;
                    write = false;
                    delete = false;
                }

                else if(cb_file_handling.Text == "Write to a File")
                {
                    txt_file_action.Text = "Write to a File:";
                    btn_fileHandling.Text = "Write";
                    rtb_file_action.Visible = true;
                    txt_content.Visible = true;
                    btn_save.Visible = true;
                    create = false;
                    read = false;
                    write = true;
                    delete = false;
                }

                else if (cb_file_handling.Text == "Delete a File")
                {
                    txt_file_action.Text = "Delete a File:";
                    btn_fileHandling.Text = "Delete";
                    rtb_file_action.Visible = false;
                    txt_content.Visible = false;
                    btn_save.Visible = false;
                    create = false;
                    read = false;
                    write = false;
                    delete = true;
                }
            }

        }

        private void btn_fileExplore_forward1_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }


        private void btn_read_Click(object sender, EventArgs e)
        {
            if (create)
            {
                try
                {
                    string file = Path.Combine(box_path.Text + @"\" + box_file_action.Text + cb_file_extension_file_action.Text);
                    char[] invalidChars = Path.GetInvalidFileNameChars();

                    if (box_file_action.Text.IndexOfAny(invalidChars) >= 0)
                    {
                        throw new ArgumentException("The file name contains invalid characters.");
                    }

                    StreamWriter sw = new StreamWriter(Application.StartupPath + file);

                    sw.Close();

                    MessageBox.Show("File created successfully.");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            else if (read)
            {
                try
                {
                    string file = Path.Combine(box_path.Text + @"\" + box_file_action.Text + cb_file_extension_file_action.Text);
                    char[] invalidChars = Path.GetInvalidFileNameChars();

                    if (box_file_action.Text.IndexOfAny(invalidChars) >= 0)
                    {
                        throw new ArgumentException("The file name contains invalid characters.");
                    }
                    if (!string.IsNullOrWhiteSpace(box_file_action.Text))
                    {
                        StreamReader sr = new StreamReader(file);

                        rtb_file_action.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                    else
                    {
                        MessageBox.Show("The File is Empty.");
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            else if (write)
            {
                try
                {
                    string file = Path.Combine(box_path.Text + @"\" + box_file_action.Text + cb_file_extension_file_action.Text);
                    char[] invalidChars = Path.GetInvalidFileNameChars();

                    if (box_file_action.Text.IndexOfAny(invalidChars) >= 0)
                    {
                        throw new ArgumentException("The file name contains invalid characters.");
                    }

                    string content = rtb_file_action.Text;
                    File.WriteAllText(file, content);

                    MessageBox.Show("Successfully Written to " + box_file_action.Text + cb_file_extension_file_action);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            else if (delete)
            {
                try
                {
                    string file = Path.Combine(box_path.Text + @"\" + box_file_action.Text + cb_file_extension_file_action.Text);
                    char[] invalidChars = Path.GetInvalidFileNameChars();

                    if (box_file_action.Text.IndexOfAny(invalidChars) >= 0)
                    {
                        throw new ArgumentException("The file name contains invalid characters.");
                    }


                    try
                    {
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                            MessageBox.Show("File Deleted Successfully");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
             }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(box_path.Text + @"\" + box_file_action.Text + cb_file_extension_file_action.Text);
            StreamReader sr = new StreamReader(file);

            rtb_file_action.Text = sr.ReadToEnd();
            sr.Close();
        }

    }
}
