   M S B A M L   `   `   `  ????T  PTortuga_Lebedeva3ISP11-16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Tortuga_Lebedeva3ISP11_16.Windows!Tortuga_Lebedeva3ISP11_16.Windows  5   	   3    -Tortuga_Lebedeva3ISP11_16.Windows.WindowOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Tortuga_Lebedeva3ISP11_16.Windows     5   	     ? Title$  WindowOrder??5   	   $	??400??6   $	??800??6*    ? WindowStartupLocation$ CenterScreen=?5	   	    ? 	Resources 5
         ButtonStyle1 ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?? CornerRadius??%?   &	        ?? 5   
   " ??6%   .?5      ??  ? ?? 5      ?? 5      " ??6&   .R?5      ?? $ 40??6!   #??z??63   ._?5      ?? #??z??6/   #??z??5   /   5      5      5      5      5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??98* ?6   ?? 5      $	??47* ?6   ?? 5      $
??108* ?6   ?? 5      $	??54* ?6   ?? 5      $	??77* ?6   	 ? ColumnDefinitions	 5    
   ?? 5!      $	??50* ?6   ?? 5"      $	??49* ?6   ?? 5#      $	??61* ?6   .+?5%   
   ?? $'??!/Images/Окно заказа.jpg??6   $??3??61   $??5??6E   A? 5'   
   $??1??6   $??3??5(      $??46,31,29,29q?6#   ??5)      ?? 5*      
 ?? ImageSource$ 
 /Images/20079-ed4_wide.jpg??6    j? Stretch$ UniformToFill=?6F   5,      ?? 5.   
   -   5         ??Name$ 	Btn_Close??52      #???   5.      $	??Top=?5/      $
??Left=?50      $??71??6,   $??66??51       J? Opacity$ 0Q?52   $   $??	18,20,0,0q?60   53      ?? 55   
   -   5        $ 	Btn_Order??59      $	??Top=?55      $??Right=?56      $	??177??6-   $??2??57      $??47??58      $ 0Q?59   $   $??	0,23,10,0q?60   5:      ?? 5<   
   -   5         ??Name$ txt_Name??5<      $??Назв. блюда??6&   $??Century Gothic)?5=      $??18(?60   
???   ?$??1??5?      $
??Wrap=?5@      $??2??6(   $??
-10,98,0,0q?6<   $??2??6P   $	??526??6a    ?? TextAlignment$ Center=?6m   ?? 5B   
   -   5        $ txt_Desc??5F      $%??Краткое описание??5B      $??Century Gothic)?6,   ???	#FF706D69$??1??5D      $??2??5E      $
??Wrap=?5G      $??2??6(   $??8,4,18,4q?6<   $??14(?6N   ?? 5I   
   $,??&Время приготовления:??6   $??Century Gothic)?60   ???	#FF706D69$??1??5K      $
??Left=?5L      $	??Top=?5M      $??3??5N      $??20??6!   $	??157??6-   $??8,7,0,0q?5O      $
??Wrap=?5P      $??14(?6(   ?? 5R   
   $??	Цена:??6   $??Century Gothic)?6!   ???	#FF706D69$??2??5T      $
??Left=?5U      $	??Top=?5V      $??3??5W      $??20??6!   $??43??6-   $??8,7,0,0q?5X      $
??Wrap=?5Y      $??14(?6(   ?? 5[   
   $??Кол-во порций:??6   $??Century Gothic)?6*   ???	#FF706D69$??2??5]      $
??Left=?5^      $	??Top=?5_      $??4??5`      $??20??6!   $	??111??6-   $??8,7,0,0q?5a      $
??Wrap=?5b      $??14(?6(   ?? 5d   
   -   5        $ txt_Portions??5k      $??руб.??5d      $??Century Gothic)?6    ???	#FF706D69$??2??5f      $
??Left=?5g      $	??Top=?5h      $??4??5i      $??20??6!   $??	129,7,0,0q?5j      $
??Wrap=?5l      $??14(?6(   $??30??66   ?? 5n   
   -   5        $ txt_Time??5u      $??Quant??5n      $??Century Gothic)?6!   ???	#FF706D69$??1??5p      $??Right=?5q      $	??Top=?5r      $??3??5s      $??20??6!   $??56??6-   $??0,7,21,0q?5t      $
??Wrap=?5v      $??14(?6(   ?? 5x   
   -   5        $ txt_Sum??5      $	??Sum??5x      $??Century Gothic)?6   ???	#FF706D69$??2??5z      $
??Left=?5{      $	??Top=?5|      $??3??5}      $??20??6!   $??63??6-   $??57,7,0,0q?5~      $
??Wrap=?5?      $??14(?6(   ?? 5?   
   $??руб.??6   $??Century Gothic)?6    ???	#FF706D69$??2??5?      $
??Left=?5?      $	??Top=?5?      $??3??5?      $??20??6!   $??	129,7,0,0q?5?      $
??Wrap=?5?      $??14(?6(   $??30??66   ?? 5?   
   $??Общая сумма:??6   $??Century Gothic)?6(   ???	#FF706D69$??1??5?      $
??Left=?5?      $	??Top=?5?      $??4??5?      $??20??6!   $	??114??6-   $??8,7,0,0q?5?      $
??Wrap=?5?      $??14(?6(   ?? 5?   
   $??4??6   $??14??5?      $??30??5?      $??x??5?      
???????$??24(?5?      $	??Top=?5?      $
??Left=?5?      $??
104,15,0,0q?5?      $ Center=?5?      $??Century Gothic)?5?      ?? 5?   
   -   5        $ 	tbx_Quant??5?      $??4??5?      $??56??5?      $??28??5?      $??1??5?      
???????$??25(?5?      $??Center=?5?      $??Center=?5?      $??
22,-18,0,0q?5?      $ Center=?5?      $??Century Gothic)?5?      5?      ?? 5?   
   -	   5        $ txt_SumCost??5?      $??SumCost??5?      $??Century Gothic)?6#   ???	#FF706D69$??1??5?      $
??Left=?5?      $	??Top=?5?      $??4??5?      $??20??5?      $	??114??6    $??	122,7,0,0q?5?      $
??Wrap=?5?      $??14(?6(   ?? 5?   
   -
   5        $ Btn_Plus??5?      #???   5?      $	??Top=?5?      $
??Left=?5?      $??40??6,   $??40??5?      $ 0Q?5?   #   $??4??5?      $??18,3,0,0q?6   ?? 5?   
   -   5        $ 	Btn_Minus??5?      #???   5?      $	??Top=?5?      $??Right=?5?      $??40??6-   $??40??5?      $ 0Q?5?   $   $??4??5?      $??0,5,8,0q?6   5?      5?      