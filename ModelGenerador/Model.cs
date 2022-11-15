using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerador
{

    public class KardexSUNAT
    {
        string Periodo, RUC, RazonSocial, Establecimiento, Tipo, Metodo_va;

        public string Periodo1 { get => Periodo; set => Periodo = value; }
        public string RUC1 { get => RUC; set => RUC = value; }
        public string RazonSocial1 { get => RazonSocial; set => RazonSocial = value; }
        public string Establecimiento1 { get => Establecimiento; set => Establecimiento = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Metodo_va1 { get => Metodo_va; set => Metodo_va = value; }
    }

    public class Producto
    {
        string Cod_ex, descripcion;
        decimal Cant_Ent, CostoU_Ent, CostoT_Ent, Cod_Umed, Cubso, Cant_Sal, CostoU_Sal, CostoT_Sal, Cant_SalF, CostoU_SalF, CostoT_SalF;

        public decimal Cant_Ent1 { get => Cant_Ent; set => Cant_Ent = value; }
        public decimal CostoU_Ent1 { get => CostoU_Ent; set => CostoU_Ent = value; }
        public decimal CostoT_Ent1 { get => CostoT_Ent; set => CostoT_Ent = value; }
        public decimal Cod_Umed1 { get => Cod_Umed; set => Cod_Umed = value; }
        public decimal Cubso1 { get => Cubso; set => Cubso = value; }
        public decimal Cant_Sal1 { get => Cant_Sal; set => Cant_Sal = value; }
        public decimal CostoU_Sal1 { get => CostoU_Sal; set => CostoU_Sal = value; }
        public decimal CostoT_Sal1 { get => CostoT_Sal; set => CostoT_Sal = value; }
        public decimal Cant_SalF1 { get => Cant_SalF; set => Cant_SalF = value; }
        public decimal CostoU_SalF1 { get => CostoU_SalF; set => CostoU_SalF = value; }
        public decimal CostoT_SalF1 { get => CostoT_SalF; set => CostoT_SalF = value; }
    }
}
