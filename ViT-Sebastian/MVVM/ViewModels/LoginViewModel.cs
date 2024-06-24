
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViT_Sebastian.MVVM.ViewModels
{
    partial class LoginViewModel : ObservableObject
    {
        [RelayCommand]
        void Login()
        {
            // ОБРАЩЕНИЕ К БД
            // ВЗЯТЬ ИЗ БД ПО ТАБЕЛЬНОМУ НОМЕРУ ЗАПИСЬ И СРАВНИТЬ ПАРОЛЬ
            // ЕСЛИ ПАРОЛЬ ВЕРНЫЙ - ПУСТИТЬ В СИСТЕМУ ПЕРЕДАВ ТАБЕЛЬНЫЙ НОМЕР
        }
    }
}
