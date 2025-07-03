import 'dart:async';

import 'package:flutter/material.dart';

class ProviderHome with ChangeNotifier{

  int _numero = 1;
  bool _incrementa = true;
  Timer? _timer;

  int get numero => _numero;

  // Future DesplazarImagen(_numero) async {
  //
  //   if (_incrementa) {
  //     if (_numero < 5) {
  //       _numero++;
  //     } else {
  //       _incrementa!;
  //       _numero--;
  //     }
  //   } else {
  //     if (_numero > 0) {
  //       _numero--;
  //     } else {
  //       _incrementa;
  //       _numero++;
  //     }
  //   }
  //   notifyListeners();
  // }







  contadorImagen() {

    if(_numero == 5){
      _incrementa = false;
    } else if( _numero ==1){
      _incrementa = true;
    }

    //todo: esto es una condicion dentro de una suma
    _numero += _incrementa ? 1 : -1;
    notifyListeners();

  }


    PasarImagen(){
    DetenerImg();
    _timer =  Timer.periodic(Duration(seconds: 7), (timer) {
       contadorImagen();
      });
  }

  void DetenerImg() {
    _timer?.cancel();
    _timer = null;
  }

  @override
  void dispose() {
    // TODO: implement dispose
    DetenerImg();
    super.dispose();
  }


}
