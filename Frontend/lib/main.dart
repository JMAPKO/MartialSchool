import 'package:flutter/material.dart';
import 'package:pakuayb/src/routes/Routes.dart';
import 'package:pakuayb/src/routes/RoutesNames.dart';


void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Pakuayb',
      routes: Routes(),
      initialRoute: RouteNames.Home,
    );
  }
}