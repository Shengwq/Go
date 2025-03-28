# Go
自己写的C#五子棋小游戏
>轻量级，不需要联网，想玩就玩

**五子棋起源于中国，是全国智力运动会竞技项目之一，是一种两人对弈的纯策略型棋类游戏。双方分别使用黑白两色的棋子，下在棋盘直线与横线的交叉点上，先形成五子连珠者获胜。**
**五子棋容易上手，老少皆宜，而且趣味横生，引人入胜。它不仅能增强思维能力，提高智力，而且富含哲理，有助于修身养性。**

#### GO 1.0 

开始界面

![image-1](https://github.com/Shengwq/Go/blob/main/Picture/开始页面.png)

仅具有双人对战功能

![image-2](https://github.com/Shengwq/Go/blob/main/Picture/PVP.png)
反应很灵敏，多次测试没发现BUG

#### GO 1.1

新增了人机对战的初级电脑功能

具有难度选择页面和人机对战页面

###### 难度选择页面

![image-3](https://github.com/Shengwq/Go/blob/main/Picture/难度选择.png)

###### 初级人机对战

![image-4](https://github.com/Shengwq/Go/blob/main/Picture/初级难度.png)

电脑代码逻辑：

优先级1-堵三连珠：如果白子（玩家）出现三连珠，优先堵上

优先级2-追踪棋子：电脑下的每个棋子都在你所下的前一个棋子旁

但依旧很智障。。。想赢电脑有手就行