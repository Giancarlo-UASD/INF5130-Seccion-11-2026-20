using Xunit;
using System;
using System.Collections.Generic;

public class SistemaAlquilerTests{
    [Fact]
    public void Test_Vehiculo_Disponibilidad_SinSolapamientos(){
        // Arrange
        // Inicializamos un automóvil (ajusta los parámetros según tus constructores)
        Automovil auto = new Automovil(1, "Toyota", "Corolla", 2023, 45.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", true, 400);
        List<Reserva> reservas = new List<Reserva>();
        
        DateTime inicioConsulta = DateTime.Today.AddDays(2);
        DateTime finConsulta = DateTime.Today.AddDays(5);

        // Act
        bool estaDisponible = auto.EstaDisponible(inicioConsulta, finConsulta, reservas);

        // Assert
        Assert.True(estaDisponible, "El vehículo debería estar disponible cuando no hay reservas registradas.");
    }

    [Fact]
    public void Test_Tarifa_Polimorfica(){
        // Arrange
        // Verificamos el comportamiento polimórfico del cálculo de tarifas según el tipo de vehículo
        Vehiculo auto = new Automovil(6, "Mazda", "3", 2022, 48.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", true, 350);
        Vehiculo moto = new Motocicleta(11, "Yamaha", "MT-03", 2022, 30.0m, EstadoVehiculo.Disponible, 321, "Naked", 1, true, false);
        int diasAlquiler = 3;

        // Act
        decimal tarifaAuto = auto.CalcularTarifa(diasAlquiler);
        decimal tarifaMoto = moto.CalcularTarifa(diasAlquiler);

        // Assert
        // Comprobamos que ambas calculan correctamente de forma independiente (polimorfismo)
        Assert.True(tarifaAuto > 0);
        Assert.True(tarifaMoto > 0);
        Assert.NotEqual(tarifaAuto, tarifaMoto);
    }

    [Fact]
    public void Test_Devolucion_Y_CierreContrato(){
        // Arrange
        Cliente cliente = new Cliente(106, "Carmen Sánchez", "003-6677889-6", "LIC-9900", DateTime.Now.AddYears(4), "849-555-0644");
        Vehiculo auto = new Automovil(8, "Ford", "Escape", 2023, 65.0m, EstadoVehiculo.Disponible, 5, 5, "Gasolina", true, 600);
        
        DateTime inicio = DateTime.Today.AddDays(-5);
        DateTime fin = DateTime.Today.AddDays(-1);
        Reserva reserva = new Reserva(1, inicio, fin, DateTime.Now.AddDays(-6), EstadoReserva.Confirmada, cliente, auto);
        
        Contrato contrato = new Contrato(1, inicio, fin, null, 200m, 15000, reserva);

        int kmInicial = contrato.KilometrajeInicial;
        int kmFinal = 15500;

        // Act
        // Simulamos la devolución registrando el kilometraje final y finalizando el contrato/vehículo
        contrato.RegistrarDevolucion(kmFinal); // O el método que hayas definido para la devolución

        // Assert
        Assert.Equal(kmFinal, contrato.KilometrajeFinal);
        Assert.Equal(EstadoVehiculo.Disponible, auto.Estado); // El vehículo debe quedar libre tras la devolución
        Assert.True(!contrato.EsActivo);
    }
}