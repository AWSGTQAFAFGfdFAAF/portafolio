using System;

namespace DatosLayer
{
    public class Customers
    {
        // Propiedades de la clase Customer con nombres descriptivos y organizadas por categorías
        // Información básica del cliente
        public string CustomerID { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;

        // Información de contacto
        public string ContactName { get; set; } = string.Empty;
        public string ContactTitle { get; set; } = string.Empty;

        // Dirección y ubicación
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        // Información de comunicación
        public string Phone { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;

        // Método que retorna una descripción completa del cliente
        public override string ToString()
        {
            return $"Customer ID: {CustomerID}\n" +
                   $"Company Name: {CompanyName}\n" +
                   $"Contact Name: {ContactName}\n" +
                   $"Contact Title: {ContactTitle}\n" +
                   $"Address: {Address}, {City}, {Region}, {PostalCode}, {Country}\n" +
                   $"Phone: {Phone}\n" +
                   $"Fax: {Fax}";
        }
    }
}
