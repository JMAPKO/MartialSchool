import 'package:flutter/material.dart';
import 'package:pakua_yb/provider/ProviderHome.dart';
import 'package:pakua_yb/routes/route.dart';
import 'package:provider/provider.dart';


void main() {
  runApp(
    ChangeNotifierProvider(
      create: (context) {
      var prov = ProviderHome();
      prov.PasarImagen();
      return prov;
    },
    child: MyApp(),
    )
  );
}


class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'pakua yb',
      debugShowCheckedModeBanner: false,
      routes: GetRoute(),
      initialRoute: "/",
    );
  }
}
