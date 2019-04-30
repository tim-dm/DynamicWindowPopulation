# DynamicWindowPopulation
A c# design solution for mimicking MVVM in WinForms

This design allows you to dynamically create Forms, dynamically swap out their controls and dynamically swap the databindings of said controls.


###### BaseWindow

The BaseWindow is a Form that inherits from System.Windows.Forms.Form. It has a custom BaseView property for storing the window's current view.


###### BaseView

The BaseView is a UserControl that inherits from System.Windows.Forms.UserControl. It contains a custom BaseViewModel property for storing the current ViewModel for the view.

The ViewModel property is also responsible for updating the databindings of the controls in the view.



###### BaseViewModel

The BaseViewModel class inherits INotifyPropertyChanged and contains the PropertyChanged methods and some debugging aids.


