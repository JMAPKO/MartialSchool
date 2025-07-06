import 'package:flutter/material.dart';
import 'package:pakuayb/src/routes/RoutesNames.dart';
import 'Opciones.dart';


class Contenedor extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    return GridView(
      gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(crossAxisCount: 2),
      children: [
        Opcion(),

        InkWell(
            onTap: () {
              Navigator.pushNamed(context, RouteNames.Alumno);
            },
            child: Opcion(titulo: "Alumnos", color: Color.fromRGBO(210, 89, 65, 1),)),

        Opcion(titulo: "Administracion", color: Color.fromARGB(120, 223, 100,10),)
      ],
    );
  }
}