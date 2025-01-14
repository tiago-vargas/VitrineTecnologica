using System;

namespace VitrineTecnologica.Pages.Labs;

public class Lab
{
	public required string Name { get; set; }
	public required string Description { get; set; }
	public required string Summary { get; set; }
	public required string ProductsServices { get; set; }
	public required Collaborator Coordinator { get; set; }
	public required List<Collaborator> Collaborators { get; set; }
}

public class Collaborator
{
	public required string Name { get; set; }
	public required string AreaOfExpertise { get; set; }
}
