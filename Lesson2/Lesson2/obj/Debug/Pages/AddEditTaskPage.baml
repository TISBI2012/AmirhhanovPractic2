   M S B A M L   `   `   `  ����  Lesson2#    Lesson2.Pages.AddEditTaskPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  AddEditTaskPage��5      .��5      � ���#F0F0F0 � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��5q�6I   $��40��6T   ��6   �� *Description+ �� Mode$ TwoWay=�6T   �� 5   
   -   5         ��Name$ ImportanceComboBox��5       $��1��6    �� DisplayMemberPath$
 Name��6<    �� SelectedValuePath$ Id��6U   $��5q�6�   $��40��6�    �� SelectedValue 6l   �� *ImportanceId+$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5   
   $��2��6   $��5q�6Q   $��40��6\      SelectedDate 6"   �� *
Deadline+$ TwoWay=�6\   �� 5   
   $��3��6   $��Выполнена��6O   $��5q�6c    d� 	IsChecked 6    �� *IsCompleted+$ TwoWay=�6c   �� 5   
   -   5        $��4��5      $��Сохранить��6   $��5q�6E   $��40��6P   ���#2196F3
�������6q   �� 5   
   -   5        $��5��5      $*��$Вернуться к задачам��6   $��5q�6X   $��40��6c   ���#FFC107
���   �6�   5      5      