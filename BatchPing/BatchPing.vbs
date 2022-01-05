Dim a
Set a=Wscript.CreateObject("Wscript.Shell")
a.run "iexplore.exe 192.168.5.1"
Wscript.Sleep 1000
a.SendKeys "admin" '用户名
Wscript.Sleep 600
a.SendKeys "{TAB}"
a.SendKeys "1" '密码
Wscript.Sleep 600
a.SendKeys "{ENTER}"