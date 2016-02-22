package Patrones_De_Dise�o;

//en nuestro ejemplo tenemos una clase abstracta llamada  TRiangulo de la cual
//heredan 3 tipos de triangulos conocidos
public abstract class Triangulo {

	private int ladoA;
	private int ladoB;
	private int ladoC;

	public Triangulo(int ladoA, int ladoB, int ladoC) {
		setLADO_A(ladoA);
		setLADO_B(ladoB);
		setLADO_C(ladoC);

	}

	// cada subclase debe redefinir estos 3 metodos abstractos

	public abstract String getDescripcion();

	public abstract double getSuperficie();

	public abstract void dibujate();

	public int getladoA() {
		return ladoA;

	}

	public void setLADO_A(int ladoA) {

	}

	public void setLADO_B(int ladoB) {

	}

	public void setLADO_C(int ladoC) {

	}
}
