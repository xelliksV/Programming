using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Contacts.controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события вставки текста в текстовое поле номера телефона.
        /// Проверяет допустимость вставляемого текста и отменяет вставку при необходимости.
        /// </summary>
        /// <param name="sender">Источник события </param>
        /// <param name="e">Аргументы события вставки</param>
        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(DataFormats.Text))
            {
                string text = (string)e.DataObject.GetData(DataFormats.Text);

                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        /// <summary>
        /// Проверяет, содержит ли текст только допустимые для номера телефона символы.
        /// </summary>
        /// <param name="text">Проверяемый текст</param>
        /// <returns>
        /// true - если текст содержит только цифры, '+', '-', '(', ')' и пробелы;
        /// false - если найдены другие символы
        /// </returns>
        private bool IsTextAllowed(string text)
        {
            return Regex.IsMatch(text, @"^[\d\+\-\(\)\s]+$");
        }
    }
}
