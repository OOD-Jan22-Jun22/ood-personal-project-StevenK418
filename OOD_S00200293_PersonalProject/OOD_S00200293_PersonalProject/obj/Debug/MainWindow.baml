   M S B A M L   `   `   `  ����X  TOOD_S00200293_PersonalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:OOD_S00200293_PersonalProjectOOD_S00200293_PersonalProject  5   	   .    (OOD_S00200293_PersonalProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:OOD_S00200293_PersonalProject     5   	   -   5            MaterialDesignDarkBackground#���   5   	     MaterialDesignBodyLight#���  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��664��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
LBX_Movies��5       * &MaterialDesignChoiceChipPrimaryListBox#��[ 6&   $
��Left=�6f   $	��144��6�   $��
10,146,0,0q�6�   $	��Top=�6�   $	��308��6�   $��0��6�    �� SelectedIndex$ 0��6  �� 5   
   -   5         ��Name$ 
TBX_Search��5        MaterialDesignTextBoxBase#��[ 6&   $
��Left=�6Y   $��31��6t   $��	10,56,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��308��6�   $��0��6�   �� 5   
   $��Movie Database��6     MaterialDesignLabel#��[ 6)   $
��Left=�6V   $��	10,15,0,0q�6q   $	��Top=�6�   $	��300��6�   $��41��6�   $��0��6�   $��24(�6�   	� 5   
   -   5         	�Name$ 	RDBTN_All��5      $	��All��6)    	� 	GroupName$ Category_filter��67   $
��Left=�6S   $��
23,304,0,0q�6n   $��0��6�   $	��Top=�6�    d� 	IsChecked$
 TrueY�6�   6�   	� 5   
   -   5        $ RDBTN_ReleaseDate��5      $
��Year��61   $ Category_filter��6@   $
��Left=�6\   $��111,302,0,0q�6w   $��0��6�   $	��Top=�6�   6�   	� 5   
   -   5        $ RDBTN_Publisher��5      $��Director��6/   $ Category_filter��6B   $
��Left=�6^   $��
23,327,0,0q�6y   $��0��6�   $	��Top=�6�   6�   	� 5   
   -   5        $ RDBTN_Rating��5      $��Rating��6,   $ Category_filter��6=   $
��Left=�6Y   $��111,327,0,0q�6t   $��0��6�   $	��Top=�6�   6�   �� 5   
   -   5        	 ��Name$	 BTN_DBAddMovie��5        MaterialDesignPaperButton#��[ 6)   $��	Add to DB��6\   $
��Left=�6p   $��
23,366,0,0q�6�   $��0��6�   $	��Top=�6�   $	��101��6�   $��28��6�   6�   �� 5   
   -	   5        $	 
BTN_AddNew��5       $  MaterialDesignRaisedAccentButton#��[ 6%   $��Add New Game��6_   $
��Left=�6v   $��148,366,0,0q�6�   $��0��6�   $	��Top=�6�   $��92��6�   $��29��6�   6�   �� 5   
   -
   5        
 ��Name$
 IMG_CoverArt��5      $
��Left=�6&   $	��108��6A   $��	28,38,0,0q�6N   $��1��6b   $	��Top=�6r   $��76��6�   �� 5   
   $��Release Date:��6   $
��Left=�6(   $��
28,273,0,0q�6C   $��1��6W   $	��Top=�6g   $��91��6   $
��Bold"�6�   �� 5   
   $��	Director:��6   $
��Left=�6$   $��
28,302,0,0q�6?   $��1��6S   $	��Top=�6c   $��76��6{   $
��Bold"�6�   �� 5   
   $��Rated:��6   $
��Left=�6!   $��
28,358,0,0q�6<   $	��Top=�6P   $��1��6h   $
��Bold"�6x    J� RenderTransformOrigin$ -0.303,0.264&�6�   �� 5   
   -   5         ��Name$ TBLK_ReleaseDate��5      $
��Left=�6.   $��121,277,0,0q�6I   $
��Wrap=�6^   $��1��6r   $	��Top=�6�   �� 5    
   -   5        $ TBLK_Director��5       $
��Left=�6+   $��121,308,0,0q�6F   $
��Wrap=�6[   $��1��6o   $	��Top=�6   �� 5!   
   -   5        $ 	TBLK_PEGI��5!      $
��Left=�6'   $��121,366,0,0q�6B   $
��Wrap=�6W   $��1��6l   $	��Top=�6|   �� 5"   
   -   5        $ TBLK_Description��5"      $
��Left=�6.   $��
28,192,0,0q�6I   $
��Wrap=�6]   $��1��6q   $	��Top=�6�   $��80��6�   $	��260��6�   ��. 6�   �� 5#   
   -   5        $ 
TBLK_Title��5#      $
��Left=�6(   $��
28,160,0,0q�6C   $
��Wrap=�6W   $��1��6k   $	��Top=�6{   $��26��6�   $	��224��6�   �� 5$   
   -   5        $	 BTN_SearchMovie��5$      #��[ 6*   $��Search��6d   $��0��6u   $
��Left=�6�   $��	10,92,0,0q�6�   $	��Top=�6�   $��75��6�   $��31��6�   �� 5%   
   -   5        $ TBLK_IMDBRating��5%      $
��Left=�6-   $��121,333,0,0q�6H   $
��Wrap=�6]   $��1��6q   $	��Top=�6�   �� 5&   
   -   5         ��Name$ 
IMDBRating��5&      $��IMDB Rating:��6$   $
��Left=�6;   $��
28,327,0,0q�6V   $��1��6j   $	��Top=�6z   $
��Bold"�6�   	� 5'   
   -   5        $ 	RDBTN_API��5'      $ Search_Source_Selection��6)   $	��API��6M   $
��Left=�6[   $��182,100,0,0q�6v   $��0��6�   $	��Top=�6�   $
 TrueY�6�   6�   	� 5(   
   -   5        $ RDBTN_Database��5(      $ Search_Source_Selection��6.   $��Database��6R   $
��Left=�6e   $��247,100,0,0q�6�   $��0��6�   $	��Top=�6�   6�   �� 5)   
   #��[ 6   $��Source:��6=   $
��Left=�6O   $��
130,96,0,0q�6j   $��0��6~   $	��Top=�6�   �� 5*   
   -   5         ��Name$ CHKBX_TitleOnly��5*      $��
Title Only��6,   $
��Left=�6A   $��
10,125,0,0q�6\   $	��Top=�6p   5+      5,      