   M S B A M L   `   `   `  ����P  LValidatesOnDataErrors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ValidatesOnDataErrorsValidatesOnDataErrors  5   	   &     ValidatesOnDataErrors.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   EvalidatesOnDataErrors#clr-namespace:ValidatesOnDataErrors     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5      "   ValidatesOnDataErrors.Person 
  Person �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%�   &	        '��        5   
   6'   �� 5	   
   " ��6    5
      P� 5       �@=�HasError$
 true��69   . �5      ��  �@�ToolTip 60   ��  �� *Self+$)	 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � .+�5   
   �� $	��200��6   $��25��6   ��6*   �� 
 �� Source#
 [  $
	 Name� �� ValidatesOnDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�5      5      