   M S B A M L   `   `   `  ���� X  TOOD_S00200293_PersonalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:OOD_S00200293_PersonalProjectOOD_S00200293_PersonalProject  .    (OOD_S00200293_PersonalProject.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     =local+clr-namespace:OOD_S00200293_PersonalProject     -       MaterialDesignDarkBackground#���     MaterialDesignBodyLight#���    � Title$  
MainWindow��$	��450��$	��664��.���  � ColumnDefinitions �� $��* ��� $��* �.+��� -    ��Name$ 
LBX_Movies�� * &MaterialDesignChoiceChipPrimaryListBox#��[ $
��Left=�$	��144��$��
10,146,0,0q�$	��Top=�$	��308��$��0�� �� SelectedIndex$ 0���� -    ��Name$ 
TBX_Search��  MaterialDesignTextBoxBase#��[ $
��Left=�$��31��$��	10,56,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��308��$��0���� $��Movie Database��  MaterialDesignLabel#��[ $
��Left=�$��	10,15,0,0q�$	��Top=�$	��300��$��41��$��0��$��24(�	� -    	�Name$ 	RDBTN_All��$	��All�� 	� 	GroupName$ Category_filter��$
��Left=�$��
23,304,0,0q�$��0��$	��Top=�	� -   $ RDBTN_ReleaseDate��$��Release Date��$ Category_filter��$
��Left=�$��111,302,0,0q�$��0��$	��Top=�	� -   $ RDBTN_Publisher��$��	Publisher��$ Category_filter��$
��Left=�$��
23,327,0,0q�$��0��$	��Top=�	� -   $ 
RDBTN_ESRB��$��Rating��$ Category_filter��$
��Left=�$��111,327,0,0q�$��0��$	��Top=��� -    ��Name$ 
BTN_Random��  MaterialDesignPaperButton#��[ $��	Add to DB��$
��Left=�$��
23,366,0,0q�$��0��$	��Top=�$	��101��$��28���� -	   $ 
BTN_AddNew�� $  MaterialDesignRaisedAccentButton#��[ $��Add New Game��$
��Left=�$��148,366,0,0q�$��0��$	��Top=�$��92��$��29���� -
   	 ��Name$	 IMG_CoverArt��$
��Left=�$	��108��$��	28,38,0,0q�$��1��$	��Top=�$��76��$��CallofDutycover.jpg���� $��Release Date:��$
��Left=�$��
28,273,0,0q�$��1��$	��Top=�$��91��$
��Bold"��� $��	Director:��$
��Left=�$��
28,302,0,0q�$��1��$	��Top=�$��76��$
��Bold"��� $��Rated:��$
��Left=�$��
28,358,0,0q�$	��Top=�$��1��$
��Bold"�
 J� RenderTransformOrigin$
 -0.303,0.264&��� -    ��Name$ TBLK_ReleaseDate��$
��Left=�$��121,277,0,0q�$
��Wrap=�$��1��$��	TextBlock��$	��Top=��� -   $ TBLK_Director��$
��Left=�$��121,308,0,0q�$
��Wrap=�$��1��$��	TextBlock��$	��Top=��� -   $ 	TBLK_PEGI��$
��Left=�$��121,366,0,0q�$
��Wrap=�$��1��$��	TextBlock��$	��Top=��� -   $ TBLK_Description��$
��Left=�$��
28,192,0,0q�$
��Wrap=�$��1��$��	TextBlock��$	��Top=�$��80��$	��260����. �� -   $ 
TBLK_Title��$
��Left=�$��
28,160,0,0q�$
��Wrap=�$��	TextBlock��$��1��$	��Top=�$��26��$	��224���� -   $ BTN_SearchMovie��#��[ $��Search��$��0��$
��Left=�$��	10,92,0,0q�$	��Top=�$��75��$��31���� -   $ TBLK_IMDBRating��$
��Left=�$��121,333,0,0q�$
��Wrap=�$��	TextBlock��$��1��$	��Top=��� -    ��Name$ 
IMDBRating��$��IMDB Rating:��$
��Left=�$��
28,327,0,0q�$��1��$	��Top=�$
��Bold"�	� -   $ 	RDBTN_API��$ Search_Source_Selection��$	��API��$
��Left=�$��182,100,0,0q�$��0��$	��Top=� d� 	IsChecked$
 TrueY�	� -   $ RDBTN_Database��$ Search_Source_Selection��$��Database��$
��Left=�$��247,100,0,0q�$��0��$	��Top=��� #��[ $��Source:��$
��Left=�$��
130,96,0,0q�$��0��$	��Top=��� -    ��Name$ CHKBX_TitleOnly��$��
Title Only��$
��Left=�$��
10,125,0,0q�$	��Top=�