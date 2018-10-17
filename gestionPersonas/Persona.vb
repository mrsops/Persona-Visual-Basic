Public Class Persona
	Private nombre As String
	Private dni As String
	Private sexo As String
	Private edad As Integer
	Private peso As Double
	Private altura As Double


	Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal sexo As String)
		Me.nombre = nombre
		Me.edad = edad
		Me.sexo = sexo
	End Sub
	Sub New()

	End Sub

	Sub New(ByVal dni As String, ByVal nombre As String, ByVal edad As Integer, ByVal sexo As String, ByVal peso As Double, ByVal altura As Double)
		Me.nombre = nombre
		Me.edad = edad
		Me.sexo = sexo
		Me.altura = altura
		Me.peso = peso
		Me.dni = dni
	End Sub


	Public Function CalcularIMC() As Integer
		If (Me.peso / (altura * altura) >= 30) Then 'Estassss GOOOORDO
			Return 2
		ElseIf (Me.peso / (altura * altura) >= 25 And Me.peso / (altura * altura) < 30) Then 'Te sobren els torrons de nadal
			Return 1
		ElseIf (Me.peso / (altura * altura) >= 18.5 And Me.peso / (altura * altura) < 25) Then ' Estas de puta mare
			Return 0
		ElseIf (Me.peso / (altura * altura) < 18.5) Then 'Tio, eres tan pleb, que no tens ni pa menjar
			Return -1
		End If
	End Function

	Public Function esMayorDeEdad() As Boolean
		If (Me.edad >= 18) Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Function toString() As String
		Return "Nombre: " & Me.nombre & " Dni: " & Me.dni & " Sexo: " & Me.sexo & " Edad: " & Me.edad & " Peso: " & Me.peso & " Altura: " & altura
	End Function

	Public Function comprobarSexo() As Char
		If (Me.sexo = "Hombre" Or Me.sexo = "hombre" Or Me.sexo = "H" Or Me.sexo = "h") Then
			Return "h"
		End If
	End Function





	Public Function getNombre() As String
		Return Me.nombre
	End Function

	Public Function getDni() As String
		Return Me.dni
	End Function

	Public Function getSexo() As String
		Return Me.sexo
	End Function

	Public Function getPeso() As Double
		Return Me.peso
	End Function

	Public Function getAltura() As Double
		Return Me.altura
	End Function

	Public Sub setNombre(ByVal nombre As String)
		Me.nombre = nombre
	End Sub

	Public Sub setDni(ByVal dni As String)
		Me.dni = dni
	End Sub

	Public Sub setSexo(ByVal sexo As String)
		Me.sexo = sexo
	End Sub

	Public Sub setPeso(ByVal peso As Double)
		Me.peso = peso
	End Sub

	Public Sub setAltura(ByVal altura As Double)
		Me.altura = altura
	End Sub
End Class
