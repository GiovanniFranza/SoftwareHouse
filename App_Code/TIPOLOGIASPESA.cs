﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class TIPOLOGIASPESA
{

    #region Membri

    private int codiceTipoSpesa;
    private string DescrizioneTipoSpesa;

    #endregion Membri

    #region Costruttore
    public TIPOLOGIASPESA()
    {

    }

    #endregion Costruttore

    #region Proprietà
    public int Codice
    {
        set { codiceTipoSpesa = value; }
        get { return codiceTipoSpesa; }
    }

    public string Descrizione
    {
        set { DescrizioneTipoSpesa = value; }
        get { return DescrizioneTipoSpesa; }
    }

    #endregion Proprietà

    #region Metodi
    public void CRUD(string descrizione)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", descrizione);

        cmd.CommandText = "TIPOLOGIESPESE_Insert";
        c.EseguiSpCmdParam(cmd);
    }
    public void CRUD(int codiceTipoSpesa, string descrizione)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", codiceTipoSpesa);
        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", descrizione);

        cmd.CommandText = "TIPOLOGIESPESE_Update";
        c.EseguiSpCmdParam(cmd);

    }
    public bool CheckOne(string descrizione)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", descrizione);
        cmd.CommandText = "TIPOLOGIESPESE_CheckOne";

        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;

    }
    public DataTable Select()
    {

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TIPOLOGIESPESE_SelectAll";
        return c.EseguiSpSelectParam(cmd);
    }

    public DataTable Select(int codice)
    {

        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", codiceTipoSpesa);
        cmd.CommandText = "TIPOLOGIESPESE_TEXTBOX";

        return dt = c.EseguiSpSelectParam(cmd);
    }

    #endregion Metodi
}