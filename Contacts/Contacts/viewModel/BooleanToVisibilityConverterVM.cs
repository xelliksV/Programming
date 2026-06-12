using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace ViewModel
{
    /// <summary>
    /// Конвертер, преобразующий значение типа <see cref="bool"/> в значение перечисления <see cref="Visibility"/> и обратно.
    /// </summary>
    public class BoolToVisibilityConverterVM : IValueConverter
    {
        /// <summary>
        /// Преобразует значение типа <see cref="bool"/> в значение перечисления <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение типа <see cref="bool"/> для преобразования.</param>
        /// <param name="targetType">Тип целевого свойства (не используется).</param>
        /// <param name="parameter">Параметр конвертера (не используется).</param>
        /// <param name="culture">Культура для использования в конвертере (не используется).</param>
        /// <returns>
        /// Возвращает <see cref="Visibility.Visible"/>, если значение равно <c>true</c>,
        /// и <see cref="Visibility.Collapsed"/> в противном случае.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        /// <summary>
        /// Преобразует значение перечисления <see cref="Visibility"/> обратно в значение типа <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Значение перечисления <see cref="Visibility"/> для преобразования.</param>
        /// <param name="targetType">Тип целевого свойства (не используется).</param>
        /// <param name="parameter">Параметр конвертера (не используется).</param>
        /// <param name="culture">Культура для использования в конвертере (не используется).</param>
        /// <returns>
        /// Возвращает <c>true</c>, если значение равно <see cref="Visibility.Visible"/>,
        /// и <c>false</c> в противном случае.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility visibility)
            {
                return visibility == Visibility.Visible;
            }

            return false;
        }
    }
}