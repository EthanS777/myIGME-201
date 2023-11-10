using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleLib;
using PeopleAppGlobals;
using System.Security.Cryptography.X509Certificates;

namespace EditPerson
{
    public partial class PersonEditForm : Form
    {
        Person formPerson;
        
        public PersonEditForm(Person person, Form parentForm)
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.Tag = false;
            }

            if( parentForm != null)
            {
                this.Owner = parentForm;
                this.CenterToParent();
            }

            this.formPerson = person;

            this.okButton.Enabled = false;

            this.nameText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating);
            this.emailText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating);
            this.ageText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating);
            this.licText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating); ;
            this.gpaText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating); ;
            this.specText.Validating += new CancelEventHandler(this.TxtBoxEmpty__Validating);

            this.nameText.TextChanged += new EventHandler(this.TxtBoxEmpty__TextChanged);
            this.emailText.TextChanged += new EventHandler(this.TxtBoxEmpty__TextChanged);
            this.ageText.TextChanged += new EventHandler(this.TxtBoxEmpty__TextChanged);
            this.licText.TextChanged += new EventHandler(this.TxtBoxEmpty__TextChanged); ;
            this.gpaText.TextChanged += new EventHandler(this.TxtBoxEmpty__TextChanged); ;
            this.specText.TextChanged += new EventHandler(this.TxtBoxEmpty__TextChanged);

            // #2: set event handler method to ClassRadioButton__CheckedChanged for each button & .CheckedChanged event
            this.froshRadioButton.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.sophRadioButton.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.juniorRadioButton.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);
            this.seniorRadioButton.CheckedChanged += new EventHandler(ClassRadioButton__CheckedChanged);

            // for .eGender, depending on pronoun check that gender radio button
            switch(person.eGender)
            {
                case genderPronoun.him:
                    himRadioButton.Checked = true;
                    break;
                case genderPronoun.her:
                    herRadioButton.Checked = true;
                    break;
                case genderPronoun.them:
                    themRadioButton.Checked = true;
                    break;
                default:
                    herRadioButton.Checked = true;
                    break;
            }
            // if no name yet, default gender button to Them
            if (person.name == null)
            {
                themRadioButton.Checked = true;
            }
            // if a type of student, check class radio button based on year
            if (person.GetType() == typeof(Student)) {
                Student student = (Student)person;
                switch (student.eCollegeYear)
                {
                    case collegeYear.freshman:
                        froshRadioButton.Checked = true;
                        break;
                    case collegeYear.sophomore:
                        sophRadioButton.Checked = true;
                        break;
                    case collegeYear.junior:
                        juniorRadioButton.Checked = true;
                        break;
                    case collegeYear.senior:
                        seniorRadioButton.Checked = true;
                        break;
                    default:
                        seniorRadioButton.Checked = true;
                        break;
                }
            }


            // #6: Improve UX by changing colors, design

            this.BackColor = Color.BlueViolet;
            this.typeLabel.ForeColor = Color.White;
            this.ageLabel.ForeColor = Color.White;
            this.nameLabel.ForeColor = Color.White;
            this.emailLabel.ForeColor = Color.White;
            this.licLabel.ForeColor = Color.White;
            this.gpaLabel.ForeColor = Color.White;
            this.specialtyLabel.ForeColor = Color.White;

            this.classOfLabel.BackColor = Color.DarkRed;
            this.classOfLabel.ForeColor = Color.Pink;
            this.classGroupBox.ForeColor = Color.AntiqueWhite;

            this.genderGroupBox.ForeColor = Color.Pink;
            this.himRadioButton.ForeColor = Color.Turquoise;
            this.herRadioButton.ForeColor = Color.Pink;
            this.themRadioButton.ForeColor = Color.LightGoldenrodYellow;

            this.nameText.BackColor = Color.Pink;
            this.nameText.ForeColor = Color.BlueViolet;
            this.emailText.BackColor = Color.Pink;
            this.emailText.ForeColor = Color.BlueViolet;
            this.ageText.BackColor = Color.Pink;
            this.ageText.ForeColor = Color.BlueViolet;
            this.gpaText.BackColor = Color.Pink;
            this.gpaText.ForeColor = Color.BlueViolet;
            this.licText.BackColor = Color.Pink;
            this.licText.ForeColor = Color.BlueViolet;
            this.typeComboBox.BackColor = Color.Pink;
           
;
            /*
            KeyPress Event for TextBox fields
            Occurs when the user presses a key sequence which generates a character(shift + A for example) within the control
                     Accepts the KeyPressEventHandler() delegate, whose method must have the following signature:
                        private void ObjectName__KeyPress(object sender, KeyPressEventArgs e)

            Example for adding the delegate method:
                    this.objectName.KeyPress += new KeyPressEventHandler(this.ObjectName__KeyPress);

            Important Fields in sender:
                TextBox tb = (TextBox)sender;
                tb.Text: the current text in the TextBox

            Important Fields in KeyPressEventArgs
                e.KeyChar: gets or sets the character just pressed allowing you to change, suppress or pass - through each character
                e.Handled: a boolean to indicate whether the delegate's method "handled" the keypress.  If it is set to true, then .NET will not process the keypress (ie. the keyboard buffer will be cleared).
            */

            // finish coding the TxtNum__KeyPress function below, which enforces digits-only in the Age, License and GPA fields,
            // and allows 1 decimal point in the GPA field.
            // using the example code on line #54, add the KeyPressEventHandler delegate function TxtNum__KeyPress for the following 3 numeric fields:
            this.ageText.KeyPress += new KeyPressEventHandler(this.TxtNum__KeyPress);
            this.licText.KeyPress += new KeyPressEventHandler(this.TxtNum__KeyPress);
            this.gpaText.KeyPress += new KeyPressEventHandler(this.TxtNum__KeyPress);

            /*
            SelectedIndexChanged Event for ComboBox Controls
            Occurs when the user changes the ComboBox value
            Accepts the empty EventHandler() delegate because the event is limited to only the current control.

            Example for adding the delegate method:
                    this.objectName.SelectedIndexChanged += new EventHandler(this.ObjectName__SelectedIndexChanged);

            The EventHandler delegate method must have the following signature:
                private void ObjectName__SelectedIndexChanged(object sender, EventArgs e)

            Important Fields in sender
                ComboBox cb = (ComboBox) sender;
                    cb.SelectedIndex: the 0-based index of the selected item
                    cb.SelectedItem: the string of the display value of the selected item

            Important Fields in EventArgs
                None.
            */

            this.typeComboBox.SelectedIndexChanged += new EventHandler(this.TypeComboBox__SelectedIndexChanged);


            /* Instructions for PE-18 - Radio Buttons and UX
             * 1. Increase the size of the form by changing:
                    MaximumSize: 842,478
                    Size: 842,478*/

               /*2. Place 7 radio buttons on the form to the right of the Combo Box, Name and Email fields.
                    They should be defined as:
                            (Name): himRadioButton  herRadioButton  themRadioButton
                            Text:   Him             Her             Them

                            (Name): froshRadioButton  sophRadioButton  juniorRadioButton    seniorRadioButton
                            Text:   Freshman          Sophomore        Junior               Senior*/



               /*3. Run the application, and notice how you can only select 1 Radio Button at a time.
                    We want to be able to select 1 Gender Radio Button, and 1 Class Year Radio Button.*/

                   /* We can do this by putting the Radio Buttons in Group Boxes.*/

               /*4. Add a GroupBox control to the form:
                        (Name): genderGroupBox 
                        Text: Gender
                        Size: 90,90
                        Location: 454, 53
                        Text: Gender
                        TabIndex: 6*/

               /*5. Drag the 3 Gender Radio Buttons onto the Gender Group Box.  */

              /* 6. Add a GroupBox control to the form:
                        (Name): classGroupBox 
                        Text: Gender
                        Size: 155,136
                        Location: 576, 53
                        Text: Class
                        TabIndex: 7*/

              /* 7. Drag the 4 Class Radio Buttons onto the Class Group Box.  */

              /* 8. Add a Label control to the bottom of the classGroupBox:
                        (Name): classOfLabel
                        Size: 143, 23
                        Text: Class of 9999
                        TextAlign: MiddleCenter*/

              /* 9. Run the application again and notice how you can now select one Gender and one Class Radio Button.


            The CheckedChanged Event for Radio Buttons
            Occurs when the Checked status changes.  
            Note that this will be called when the currently selected RadioButton unchecks and the new RadioButton becomes checked.

            Accepts the empty EventHandler() delegate because the event is limited to only the current control.

            Example for adding the delegate method:
                this.objectName.CheckedChanged += new EventHandler(this.ObjectName__CheckedChanged);

            The EventHandler delegate method must have the following signature:
                private void ObjectName__CheckedChanged(object sender, EventArgs e)

            Important Fields in sender
                RadioButton rb = (RadioButton)sender;
                rb.Checked: the current checked state of the RadioButton control.

            Important Fields in EventArgs
                None.
            */

            this.okButton.Click += new EventHandler(this.OkButton__Click);
            this.cancelButton.Click += new EventHandler(this.CancelButton__Click);


            this.nameText.Text = person.name;
            this.emailText.Text = person.email;
            this.ageText.Text = person.age.ToString();
            this.licText.Text = person.LicenseId.ToString();

            if (person.GetType() == typeof(Student))
            {
                // initialize the typeComboBox SelectedIndex to 0 (Student)
                this.typeComboBox.SelectedIndex = 0;
                Student student = (Student)person;
                this.gpaText.Text = student.gpa.ToString();
            }
            else
            {
                this.typeComboBox.SelectedIndex = 1;
                Teacher teacher = (Teacher)person;
                this.specText.Text = teacher.specialty;
            }

            this.Show();
        }

        // the Event Handler for changing the typeComboBox value (Student or Teacher)
        // if it's set to Student, show the GPA label and field, but not the Specialty label and field
        // if it's set to Teacher, show the Specialty label and field, but not the GPA label and field
        private void TypeComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            // the ComboBox SelectedIndex = 0 (Student)
            if(cb.SelectedIndex == 0 )
            {
                // set specText and specialtyLabel Visible field = false
                this.specialtyLabel.Visible = false;
                this.specText.Visible = false;

                // #4: set classGroupBox to be visible true
                this.classGroupBox.Visible = true;

                // set the specText field as valid
                this.specText.Tag = true;

                // set gpaText and gpaLabel Visible field = true
                this.gpaLabel.Visible = true;
                this.gpaText.Visible = true;

                this.gpaText.Tag = (this.gpaText.Text.Length > 0);
            }
            else
            {
                // else Teacher is selected

                // set specText and specialtyLabel Visible field = true
                this.specialtyLabel.Visible = true;
                this.specText.Visible = true;

                // #4: else set classGroupBox to be visible false
                this.classGroupBox.Visible = false;

                this.specText.Tag = (this.specText.Text.Length > 0);

                // set gpaText and gpaLabel Visible field = false
                this.gpaLabel.Visible = false;
                this.gpaText.Visible = false;

                this.gpaText.Tag = true;
            }
        }

        // #3: event handler for ClassRadioButton__CheckedChanged

        private void ClassRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            // define rb pointed to sender
            RadioButton rb = (RadioButton)sender;
            // if button checked, set the .Text of label to be different depending on button
            if (rb.Checked == true)
            {
                if (rb.Text == "Freshman")
                {
                    this.classOfLabel.Text = "Class of 2027";
                }
                else if (rb.Text == "Sophomore")
                {
                    this.classOfLabel.Text = "Class of 2026";
                }
                else if (rb.Text == "Junior")
                {
                    this.classOfLabel.Text = "Class of 2025";
                }
                else if (rb.Text == "Senior")
                {
                    this.classOfLabel.Text = "Class of 2024";
                }
            }
        }


        private void TxtNum__KeyPress(object sender, KeyPressEventArgs e)
        {
            // A key was pressed in the associated number field
            // only allow digits or a single '.' for the gpa field

            // refer to line #54 to create a TextBox reference variable, and explicitly cast the object parameter as a TextBox
            // which is the TextBox that the user typed a character in
            TextBox tb = (TextBox)sender;

            // e.KeyChar contains the character that was pressed
            // if a numeric character was entered or backspace was entered  
            // Char.IsDigit(char) checks if a char is a digit
            // '\b' is the character code for backspace
            if( Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' )
            {
                // .NET should continue to handle the keystroke (ie. add it to the textbox)
                // set e.Handled to indicate that we did not handle it
                e.Handled = false;
            }
            else
            {
                // assume that the keystroke can be flagged as being handled by us
                // (ie. drop the keystroke from the .NET buffer and don't show it in the textbox)
                e.Handled = true;

                // if the active control is the GPA field gpaText
                // then allow one '.'
                if ( tb == this.gpaText )
                {
                    // if they entered '.' and it is not already in gpaText.Text
                    if ( e.KeyChar == '.' && !tb.Text.Contains(".") )
                    {
                        // .NET should continue to handle the keystroke (ie. show it in the text box)
                        e.Handled = false;
                    }
                }
            }

            ValidateAll();
        }


        private void TxtBoxEmpty__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                this.errorProvider.SetError(tb, "This field cannot be empty.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void TxtBoxEmpty__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                this.errorProvider.SetError(tb, "This field cannot be empty.");
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void ValidateAll()
        {
            // enable or disable the OK button based on the valid state of all of the fields
            this.okButton.Enabled =
                (bool)this.nameText.Tag &&
                (bool)this.emailText.Tag &&
                (bool)this.ageText.Tag &&
                (bool)this.specText.Tag &&
                (bool)this.gpaText.Tag;
        }

        private void OkButton__Click(object sender, EventArgs e)
        {
            Student student = null;
            Teacher teacher = null;
            Person person = null;

            Globals.people.Remove(this.formPerson.email);

            // #5: set person.eGender based on which gender button is selected
            if (himRadioButton.Checked == true)
            {
                person.eGender = genderPronoun.him; 
            }
            else if (herRadioButton.Checked == true)
            {
                person.eGender = genderPronoun.her;
            }
            else if (themRadioButton.Checked == true) 
            {
                 //person.eGender = genderPronoun.them;
            } 


            if( this.typeComboBox.SelectedIndex == 0)
            {
                student = new Student();
                person = student;
            }
            else
            {
                teacher = new Teacher();
                person = teacher;
            }

            person.name = this.nameText.Text;
            person.email = this.emailText.Text;
            person.age = Convert.ToInt32(this.ageText.Text);
            person.LicenseId = Convert.ToInt32(this.licText.Text);

            if( person.GetType() == typeof( Student))
            {
                student.gpa = Convert.ToDouble(this.gpaText.Text);
            }
            else
            {
                teacher.specialty = this.specText.Text;
            }

           // #5: if student type, set student.eCollegeYear based on which radio button is selected
            if (person.GetType() == typeof(Student))
            {
                if (froshRadioButton.Checked == true)
                {
                    student.eCollegeYear = collegeYear.freshman;
                }
                else if (sophRadioButton.Checked == true)
                {
                    student.eCollegeYear = collegeYear.sophomore;
                }
                else if (juniorRadioButton.Checked == true)
                {
                    student.eCollegeYear = collegeYear.junior;
                }
                else if (seniorRadioButton.Checked == true)
                {
                    student.eCollegeYear = collegeYear.senior;
                }
            }

            Globals.people[person.email] = person;


            if (this.Owner != null)
            {
                // enable the parent form
                this.Owner.Enabled = true;

                // and set it into focus to process mouse and keyboard events
                this.Owner.Focus();
            }

            // close and dispose of this instance of the PersonEdit Form
            // note that these must come at the end since they clear and release the form data
            this.Close();
            this.Dispose();
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            // if the Cancel Button was pressed
            // then we just get the heck out of here

            if (this.Owner != null)
            {
                // enable the parent form
                this.Owner.Enabled = true;

                // and set it into focus to process mouse and keyboard events
                this.Owner.Focus();
            }

            // close and dispose of this instance of the PersonEdit Form
            // note that these must come at the end since they clear and release the form data
            this.Close();
            this.Dispose();
        }
    }
}