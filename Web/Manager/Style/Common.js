// JScript 文件
function CheckAll(form)  {
  for (var i=0;i<form.elements.length;i++)    {
    var e = form.elements[i];
    if (e.name != 'chkall')       e.checked = form.chkall.checked; 
   }
  }
  function isdel()
{
var ok=confirm("确定删除吗?删除后数据不能恢复!请小心删除!")
if(!ok)return false
else return true;
}

function showBtnOver(obj){
	if(obj.className.indexOf("Over")==-1)
		obj.className=obj.className+"Over";
}

function showBtnOut(obj){
	if(obj.className.indexOf("Over")>-1)
		obj.className=obj.className.replace("Over","");
}
function isExc()
{
var ok=confirm("确定执行此操作?!")
if(!ok)return false
else return true;

}