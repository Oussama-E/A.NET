   M S B A M L   `   `   `  ����D  @TopPlaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TopPlaces	TopPlaces  5   	       TopPlaces.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TopPlaces     5   	     � Title$  
MainWindow��5   	   $	��476��6   $	��800��6)    � 	Resources 5	         
TitreStyle �� Property �� Value  
LabelStyle  ItemTemplate �� Orientation��%>  &	        &	 �     &	 �     �� 5
   
   .�5      ��  � ��$ 18(�6/   �� 5       � ��
 �   �62   �� 5       � ��$ 2q�66   5      �� 5   
   .�5      ��  � ��$ 10(�6/   �� 5       � ��$ courrier new)�61   5      �� 5   
   .R�5      �� $ 
Horizontal=�6   $��0 5 0 5q�63   .+�5      �� $��50��6   $��50��6#   $
��Fill=�6/   $��Center=�6W   $��Center=�6r   ��6>   �� *Image+6r   �� 5      $��Center=�68   $��Center=�6S   ��6   �� *Description+6S   5      5      5      .��5      �  J� RenderTransformOrigin$ 0.191,0.735&�6   $��
10,44,0,25q�6/    � ColumnDefinitions 5   
   �� 5      $	��47* �6   �� 5      $
��686* �6   �� 5      $��0* �6   .+�5"   
   �� -   5         ��Name$ listBoxPhotos��5"      #��[ 5#      $��51,5,1300,300q�5%      $��2��5&      ��5$      �� 5'      �� 5)   
   -   5         ��Name$ Titre��5)      $��
Top Places��5*      #��[  5+      $��157,10,131,700q�5,      $��1��5-      �� 5/   
   -   5        	 ��Name$	 image1��5/      $��Photos/amsterdam.jpg��50      $
��Fill=�51      $��175,79,217,153q�52      $��1��53      �� 55   
   -   5        $ Description��55      $��Description : ��56      #��[ 57      $��157,700,514,88q�58      $��1��59      �� 5;   
   -   5        $ Description_value��5;      $��227,700,514,88q�5=      $��1��5>      ��5<      �� 
 �� ElementName$
 listBoxPhotos�� �� Path$ SelectedItem.Description�5>      �� 5@   
   -   5        $	 URI��5@      $��URI fichier : ��5A      #��[ 5B      $��157,730,514,55q�5C      $��1��5D      �� 5F   
   -   5        $ 	URI_value��5F      $��222,730,514,55q�5H      $��1��5I      ��5G      �� $
 listBoxPhotos��$ SelectedItem.Uri�5I      �� 5K   
   -   5        $
 Vote��5K      $��Nb votes : ��5L      #��[ 5M      $��157,750,514,25q�5N      $��1��5O      �� 5Q   
   -	   5        $ 
Vote_value��5Q      $��223,750,514,25q�5S      $��1��5T      ��5R      �� $
 listBoxPhotos��$ SelectedItem.NbVotes�5T      �� 5V   
   $��Je vote pour��6   $	��Top=�5W      $��250,780,500,25q�5X      $��1��5Y      �� 5[   
   -
   5        $��30��5[      $��40��5\      $��157,780,1200,25q�5]      $��1��5_      .��5`      �� $��images/jaime.png��6   $��45��5a      $
��Left=�5b      $��25��5c      5d      5e      5h      