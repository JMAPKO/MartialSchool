import 'package:flutter/material.dart';
import 'package:pakuayb/src/routes/RoutesNames.dart';
import 'package:pakuayb/src/screens/Alumnos.dart';
import 'package:pakuayb/src/screens/HomePage.dart';

//esto seria una funcion
Map<String, WidgetBuilder> Routes() {
  return {

          RouteNames.Home: (_) => Homepage(),
          RouteNames.Alumno: (_) => Alumnos(),

        };
}