# EmptyWindowExample

空窗口应用程序示例

English:

Overview

This is a basic C  Windows Forms application example for creating an empty window.

Demonstrates how to use the System.Windows.Forms namespace to build a simple desktop application.

Features

Create a window with a size of 800x600 pixels

Window title is "Empty Window Application Example"

Window includes maximize and minimize buttons

Window starts centered on the screen

If an app.ico file exists in the current directory, set it as the window's icon
Code Structure

BasicForm class: Inherits from the Form class, used to define the window's properties and behavior

Constructor: Sets the window's title, size, maximize/minimize buttons, and startup position. Also attempts to load and set the window icon

Main method: The entry point of the program, enables visual styles and runs an instance of BasicForm
Compilation Steps

Ensure you have the .NET development environment installed

Save the code as EmptyWindowExample.cs

Open a command-line tool and navigate to the directory where the code file is located

Compile the code:

csc /target:winexe EmptyWindowExample.cs  

Notes
If you want the window to display an icon, ensure the app.ico file exists in the same directory as the executable

This example application uses Windows Forms and can therefore only run on the Windows operating system

中文：

概述

这是一个基础的 C  Windows Forms 应用程序示例，用于创建一个空的窗口。

展示了如何使用System.Windows.Forms命名空间来构建一个简单的桌面应用程序。

功能特性

创建一个大小为 800x600 像素的窗口

窗口标题为 “空窗口应用程序示例”

窗口包含最大化和最小化按钮

窗口启动时位于屏幕中央

如果当前目录下存在app.ico文件，将其设置为窗口的图标

代码结构

BasicForm类：继承自Form类，用于定义窗口的属性和行为

构造函数：设置窗口的标题、大小、最大化和最小化按钮，以及窗口的启动位置。同时尝试加载并设置窗口图标

Main方法：程序的入口点，启用视觉样式并运行BasicForm实例

编译步骤

确保你已经安装了.NET 开发环境

将代码保存为EmptyWindowExample.cs文件。
打开命令行工具，导航到代码文件所在的目录

编译代码：

csc /target:winexe EmptyWindowExample.cs

注意事项

如果你希望窗口显示图标，请确保app.ico文件存在于可执行文件的同一目录下

该示例应用使用了 Windows Forms，因此只能在 Windows 操作系统上运行
