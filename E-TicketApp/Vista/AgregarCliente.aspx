<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="Vista.AgregarCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<link href="<?=bower_url()?>bootstrap-select/dist/css/bootstrap-select.min.css" rel="stylesheet" type="text/css">
<link href="<?=assets_url()?>css/dashboard.css" rel="stylesheet" type="text/css">

<div class="row">
	<div class="col-lg-12">
		<h1 class="page-header">Crea tu cuenta de cliente</h1>
	</div>
</div>

<div class="row">
	<div class="col-lg-12">
		<div class="panel panel-default">
			<div class="panel-heading">Formulario de creacion</div>
			<div class="panel-body">

				<form name="actividad" method="post" action="">
				<div class="row">
					<div class="col-md-6">
						<div class="form-group">
							<label for="nombre">Nombre</label>
                            <input type="text" name="nombre_input">
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-6">
						<div class="form-group">
							<label for="fecha_inicio">Fecha Inicio</label>
							<input type="text" name="fecha_inicio" class="form-control datetimepicker" placeholder="Fecha Inicio Actividad">
						</div>
					</div>
					<div class="col-md-6">					
						<div class="form-group">
							<label for="fecha_fin">Fecha Fin</label>
							<input type="text" name="fecha_fin" class="form-control datetimepicker" placeholder="Fecha Termino Actividad">
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-6">
						<div class="form-group">
							<label for="ticketwom_idticketwom">Referencia</label>
							<input type="text" name="ticketwom_idticketwom" class="form-control" placeholder="Numero de Refencia">
						</div>
					</div>
					<div class="col-md-6">
						<div class="form-group">
							<label for="prioridad">Prioridad</label>
							<select name="prioridad" class="form-control selectpicker" data-live-search="true">
								<?php foreach( $prioridades as $prioridad ) { ?>
									<option value="<?=$prioridad->idflmr_prioridad?>"><?=$prioridad->nombre?></option>
								<?php } ?>
							</select>
						</div>
					</div>
				</div>

				<div class="row ninja" id="templateQuestions">
				</div>

				<div class="row">
					<div class="col-md-12">
						<div class="form-group">
							<label for="descripcion">Descripci&oacute;n</label>
							<textarea name="descripcion" class="form-control" placeholder="Descripcion de la actividad"></textarea>
						</div>
					</div>
				</div>

				<div class="row">
					<div class="col-md-12">
						<button type="submit" class="btn btn-primary btn-block"><i class="fa fa-plus"></i> Crear Actividad</button>
					</div>
				</div>
				</form>

			</div>
		</div>
	</div>
</div>

<!-- Bootstrap DateTimePicker -->
<script type="text/javascript" src="<?=bower_url()?>moment/min/moment-with-locales.min.js"></script>
<script type="text/javascript" src="<?=bower_url()?>eonasdan-bootstrap-datetimepicker/build/js/bootstrap-datetimepicker.min.js"></script>
<link rel="stylesheet" href="<?=bower_url()?>eonasdan-bootstrap-datetimepicker/build/css/bootstrap-datetimepicker.min.css" />

<script type="text/javascript" src="<?=bower_url()?>bootstrap-select/dist/js/bootstrap-select.min.js"></script>

<!-- Custom Funcionalidades -->
<script type="text/javascript" src="<?=assets_url()?>js/actividad/crear.js?ver=<?=rand()?>"></script>
<script type="text/javascript" src="<?=assets_url()?>js/alone.alertyfy.js?ver=<?=rand()?>"></script>





<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
