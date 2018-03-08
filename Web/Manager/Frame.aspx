<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Frame.aspx.cs" Inherits="Manager_Frame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title></title>
</head>
<frameset rows="90,*" frameborder="no" border="0" framespacing="0">
  <frame src="toolbar.aspx" name="topframe" scrolling="No" id="topframe" title="topframe" />
  <frameset id="mainframeset" cols="190,2,*" frameborder="No" border="0" framespacing="0">
    <frame src="left.aspx" name="leftframe" noresize="noresize" id="leftframe" title="leftframe" />
	<frame src="frameborder.aspx" name="frameborder" scrolling="No" noresize="noresize" id="frameborder" title="frameborder" />
    <frame src="index.aspx" name="mainframe" id="mainframe" title="mainframe" scrolling="yes"/>
  </frameset>
</frameset>
<noframes>
<body>
</body>
</noframes>
</html>