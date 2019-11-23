;#DropDB SicProyectoEasyTest

#Application SicProyecto.Win
#Application SicProyecto.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef SicProyecto.Win

*Action About...
 
*Action OK

#EndIf

#IfDef SicProyecto.Web
*Action Navigation(My Details)
#EndIf
