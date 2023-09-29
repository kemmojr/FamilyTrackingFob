using System;

public class MovementPacket
{
	public MovementPacket()
	{
	}

	//The time the client device sent this data
	public DateTime SentDateTime { get; set; }

	//The time the Start position was recorded
	public DateTime StartDateTime { get; set; }

	//The time the end position was recorded
	public DateTime EndDateTime { get; set; }


	//Latitude of the start position
	public double StartLatitude { get; set; }

    //Longitude of the start position
    public double StartLongitude { get; set; }

    //Latitude of the destination position
    public double EndLatitude { get; set; }

    //Longitude of the destination position
    public double EndLongitude { get; set; }


    /*
		startLatitude	double	Latitude of the start position
		startLongitude	double	Longitude of the start position
		endLatitude	double	Latitude of the destination position
		endLongitude	double	Longitude of the destination position
	 * */
}
