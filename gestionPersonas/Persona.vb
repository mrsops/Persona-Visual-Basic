Public Class Persona
	Private nombre As String
	Private dni As String
	Private sexo As String
	Private peso As Double
	Private altura As Double


	Sub New(ByVal nombre As String, ByVal dni As String, ByVal sexo As String)

	End Sub
	Sub New()

	End Sub




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
