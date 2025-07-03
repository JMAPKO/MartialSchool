import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../provider/ProviderHome.dart';

class Imagehome extends StatelessWidget {

  //todo: al usar el consumer no necesito traer el provider como variable
  // final provider = ProviderHome();

  @override
  Widget build(BuildContext context) {

    var boxDecoration = BoxDecoration(
        borderRadius: BorderRadius.circular(20),
          border: Border(
            left: BorderSide(color: Color(0xFFFF7043), width: 5),
            right: BorderSide(color: Color(0xFFFF7043), width:5),
            top: BorderSide(color: Color(0xFFFF7043),  width: 5),
            bottom: BorderSide(color: Color(0xFFFF7043), width: 5)
          )
      );

    return Container(
      //

      child:  Consumer<ProviderHome>(
            builder: (context, value, child) {
             return AnimatedContainer(
               margin: EdgeInsets.symmetric(horizontal: 15, vertical: 10),
               decoration:boxDecoration,
               duration: Duration(milliseconds: 200),
               curve: Curves.linear,
               child: ClipRRect(
                borderRadius: BorderRadius.circular(15),
                child: AnimatedSwitcher(
                  duration: Duration(seconds: 2),
                  transitionBuilder: (child, animation) => FadeTransition(opacity: animation, child:child ,),
                  child: Image(
                    key: ValueKey(value.numero),
                    image: AssetImage("assets/img/foto${value.numero}.jpeg"),
                    height: 230,
                  ),
                ),
                           ),
             );
          }
      ),
    );
  }



}
